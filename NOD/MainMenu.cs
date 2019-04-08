
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace NOD
{
	public class MainMenu
	{
		public void Show ( )
		{
			WriteLine( "Calculating square root:" );

			var number1 = ReadPrintingValue( "Number" );
			var number2 = ReadPrintingValue( "Precision" );

			var calculatorNod = CalculatorNOD.CalculationEuclideanMethod( number1, number2, out var timeSpan );
			WriteLine( $"NOD = {calculatorNod}" );

			ReadKey( );
		}

		private int ReadPrintingValue ( string valueName )
		{
			Write( $"{valueName} = " );
			var isParsed = int.TryParse( ReadLine( ), out var value );
			return isParsed ? value : ReadPrintingValue( valueName );
		}
	}
}