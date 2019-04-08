using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD
{
	public static class CalculatorNOD
	{
		static public int CalculationEuclideanMethod ( int number1, int number2, out TimeSpan timeSpan )
		{
			var stopwatch = new Stopwatch( );
			stopwatch.Start( );

			while ( number1 != number2 )
			{
				if ( number1 > number2 )
				{
					number1 -= number2;
				}
				else
				{
					number2 -= number1;
				}
			}

			stopwatch.Stop( );
			timeSpan = stopwatch.Elapsed;
			return number1;
		}

		static public int CalculationEuclideanMethod ( int number1, int number2, int number3 )
		{
			var nodNumbers = CalculationEuclideanMethod( number1, number2, out var timeSpan1 );
			return CalculationEuclideanMethod( nodNumbers, number3, out var timeSpan2 );
		}

		static public int CalculationEuclideanMethod ( int number1, int number2, int number3, int number4 )
		{
			var nodNumbers = CalculationEuclideanMethod( number1, number2, number3 );
			return CalculationEuclideanMethod( nodNumbers, number4, out var timeSpan );
		}

		static public int CalculationEuclideanMethod ( int number1, int number2, int number3, int number4, int number5 )
		{
			var nodNumbers = CalculationEuclideanMethod( number1, number2, number3, number4 );
			return CalculationEuclideanMethod( nodNumbers, number5, out var timeSpan );
		}

		static public int CalculationGCDMethod ( int number1, int number2, out TimeSpan timeSpan )
		{
			var stopwatch = new Stopwatch( );
			stopwatch.Start( );
			
			var shift = 0;
			var temp = 0;

			if ( number1 == 0 ) {
				stopwatch.Stop( );
				timeSpan = stopwatch.Elapsed;
				return number2;
			}
			
			if ( number2 == 0 ) {
				stopwatch.Stop( );
				timeSpan = stopwatch.Elapsed;
				return number1;
			}

			while ( ( ( number1 | number2 ) & 1 ) == 0 )
			{
				shift++;
				number2 >>= 1;
				number1 >>= 1;
			}

			while ( ( number1 & 1 ) == 0 )
			{
				number1 >>= 1;
			}

			do
			{
				while ( ( number2 & 1 ) == 0 ) {
					number2 >>= 1;
				}
				
				if ( number1 > number2 )
				{
					temp = number2;
					number2 = number1;
					number1 = temp;
				}

				number2 -= number1;
			} while ( number2 != 0 );

			stopwatch.Stop( );
			timeSpan = stopwatch.Elapsed;

			return number1 << shift;
		}

	}
}
