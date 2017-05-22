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

            
            ColoredConsoleAppender  console = new ColoredConsoleAppender();
            

            
            console.AddMapping(SetLevelColors("DEBUG", LogColor.BLUE_H));
            console.AddMapping(SetLevelColors("INFO", LogColor.RED_H));
            console.Layout = patternLayout;
            console.ActivateOptions();
            
            hierarchy.Root.AddAppender(console);
            
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

        private static ColoredConsoleAppender.LevelColors SetLevelColors( string level, ColoredConsoleAppender.Colors color )
        {

            ColoredConsoleAppender.LevelColors LvlColors = new ColoredConsoleAppender.LevelColors();            
            LvlColors.Level = GetLevel(level);
            LvlColors.ForeColor = color; 

			return LvlColors;            
        }
        
        
        private static Level GetLevel(string level )
        {
        	var dictionaryLevels = new Dictionary<string, Level>()
        	{
        		{"ALL"		,	Level.All		},
        		{"DEBUG"	,	Level.Debug		},
        		{"INFO"		,	Level.Info		},
        		{"WARN"		,	Level.Warn		},
        		{"ERROR"	,	Level.Error		},
        		{"CRITICAL"	,	Level.Critical	},
        		{"FATAL"	,	Level.Fatal		},
        		{"OFF"		,	Level.Off		}
        	};
        	
        	Level temp;
        	return dictionaryLevels.TryGetValue(level, out temp) ? temp : Level.Info;
        }
         
	}
	
	public struct LogColor
	{
		public const ColoredConsoleAppender.Colors BLUE		= ColoredConsoleAppender.Colors.Blue;
		public const ColoredConsoleAppender.Colors CYAN		= ColoredConsoleAppender.Colors.Cyan;	
		public const ColoredConsoleAppender.Colors GREEN	= ColoredConsoleAppender.Colors.Green;	
		public const ColoredConsoleAppender.Colors PURPLE	= ColoredConsoleAppender.Colors.Purple;	
		public const ColoredConsoleAppender.Colors WHITE	= ColoredConsoleAppender.Colors.White;	
		public const ColoredConsoleAppender.Colors YELLOW	= ColoredConsoleAppender.Colors.Yellow;
		public const ColoredConsoleAppender.Colors RED		= ColoredConsoleAppender.Colors.Red;		
		
		public const ColoredConsoleAppender.Colors BLUE_H 	= ColoredConsoleAppender.Colors.Cyan	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors CYAN_H 	= ColoredConsoleAppender.Colors.Cyan	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors GREEN_H 	= ColoredConsoleAppender.Colors.Cyan	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors PURPLE_H = ColoredConsoleAppender.Colors.Cyan	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors WHITE_H 	= ColoredConsoleAppender.Colors.Cyan	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors YELLOW_H = ColoredConsoleAppender.Colors.Cyan	| ColoredConsoleAppender.Colors.HighIntensity;	
		public const ColoredConsoleAppender.Colors RED_H	= ColoredConsoleAppender.Colors.Red		| ColoredConsoleAppender.Colors.HighIntensity;	
	}
	
	
}
