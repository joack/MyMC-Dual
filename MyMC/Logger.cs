/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 22/05/2017
 * Hora: 07:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using log4net;
using log4net.Repository.Hierarchy;
using log4net.Core;
using log4net.Appender;
using log4net.Layout;

namespace MyMC
{
	/// <summary>
	/// Description of Logger.
	/// </summary>
	public class Logger
	{
		public Logger()
		{
		}
		
        public static void Setup()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%message%newline";
            patternLayout.ActivateOptions();

            
            hierarchy.Root.AddAppender(SetColoredConsoleAppender(patternLayout));
            hierarchy.Root.AddAppender(SetFileAppender());
            
            hierarchy.Root.Level = Level.Debug;
            hierarchy.Configured = true;
    
#region
//            roller.AppendToFile = false;
//            roller.File = @"Logs\EventLog.txt";
//            roller.Layout = patternLayout;
//            roller.MaxSizeRollBackups = 5;
//            roller.MaximumFileSize = "1GB";
//            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
//            roller.StaticLogFileName = true;            
//            roller.ActivateOptions();
//            hierarchy.Root.AddAppender(roller);
//
//            MemoryAppender memory = new MemoryAppender();
//            memory.ActivateOptions();
//            hierarchy.Root.AddAppender(memory);
//
//            hierarchy.Root.Level = Level.Info;
//            hierarchy.Configured = true;
#endregion
        }	
        
		private static RollingFileAppender SetFileAppender()
		{
			
            PatternLayout pattern = new PatternLayout();
            pattern.Header = string.Format("========== [START AT {0}] =========={1}{1}", DateTime.Now.ToString(), Environment.NewLine);
            pattern.ConversionPattern = "[%date{HH:mm:ss}]: %message%newline";
            pattern.Footer = String.Format("{0}========== [END SESSION] =========={0}{0}", Environment.NewLine);
            pattern.ActivateOptions();

			RollingFileAppender rollFile = new RollingFileAppender();
			
			rollFile.AppendToFile = true;
			rollFile.File = @".\Logs\log.txt";
			rollFile.RollingStyle = RollingFileAppender.RollingMode.Composite;
			rollFile.MaxSizeRollBackups = 5;
			rollFile.MaximumFileSize = "1MB";
			rollFile.Layout = pattern;
			rollFile.ActivateOptions();
			
			return rollFile;
		}

        private static ColoredConsoleAppender SetColoredConsoleAppender( PatternLayout patternLayout )
        {
            ColoredConsoleAppender  console = new ColoredConsoleAppender();
            
            console.AddMapping(SetLevelColors(LogLevel.DEBUG	, LogColor.CYAN_H	));
            console.AddMapping(SetLevelColors(LogLevel.INFO		, LogColor.BLUE_H	));
            console.AddMapping(SetLevelColors(LogLevel.WARN		, LogColor.RED_H	));
            console.Layout = patternLayout;
            console.ActivateOptions();  
			
			return console;            
        }
            
        private static ColoredConsoleAppender.LevelColors SetLevelColors( Level level, ColoredConsoleAppender.Colors color )
        {

            ColoredConsoleAppender.LevelColors LvlColors = new ColoredConsoleAppender.LevelColors();            
            LvlColors.Level = level;
            LvlColors.ForeColor = color; 

			return LvlColors;            
        }
         
	}
	
	internal struct LogColor
	{
		public const ColoredConsoleAppender.Colors BLUE		= ColoredConsoleAppender.Colors.Blue;
		public const ColoredConsoleAppender.Colors CYAN		= ColoredConsoleAppender.Colors.Cyan;	
		public const ColoredConsoleAppender.Colors GREEN	= ColoredConsoleAppender.Colors.Green;	
		public const ColoredConsoleAppender.Colors PURPLE	= ColoredConsoleAppender.Colors.Purple;	
		public const ColoredConsoleAppender.Colors WHITE	= ColoredConsoleAppender.Colors.White;	
		public const ColoredConsoleAppender.Colors YELLOW	= ColoredConsoleAppender.Colors.Yellow;
		public const ColoredConsoleAppender.Colors RED		= ColoredConsoleAppender.Colors.Red;		
		
		public const ColoredConsoleAppender.Colors BLUE_H 	= ColoredConsoleAppender.Colors.Blue	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors CYAN_H 	= ColoredConsoleAppender.Colors.Cyan	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors GREEN_H 	= ColoredConsoleAppender.Colors.Green	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors PURPLE_H = ColoredConsoleAppender.Colors.Purple	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors WHITE_H 	= ColoredConsoleAppender.Colors.White	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors YELLOW_H = ColoredConsoleAppender.Colors.Yellow	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors RED_H	= ColoredConsoleAppender.Colors.Red		| ColoredConsoleAppender.Colors.HighIntensity;	
	}
	
	internal struct LogLevel
	{	
		public static Level ALL		= Level.All;
		public static Level DEBUG	= Level.Debug;
		public static Level INFO	= Level.Info;
		public static Level WARN	= Level.Warn;
		public static Level ERROR	= Level.Error;
		public static Level CRITICAL= Level.Critical;
		public static Level FATAL	= Level.Fatal;
		public static Level OFF		= Level.Off;		
	}
	
	
}
