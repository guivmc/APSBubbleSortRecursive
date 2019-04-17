using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblueSortRecursive
{
    public class Program
    {
        public static int Call { get; set; } = 0;

        public static void BubbleSort( int[] arr, int n )
        {
            // Base case 
            if( n == 1 )
                return;

            // One pass of bubble  
            // sort. After this pass, 
            // the largest element 
            // is moved (or bubbled)  
            // to end. 
            for( int i = 0; i < n - 1; i++ )
                if( arr[i] > arr[i + 1] )
                {
                    // swap arr[i], arr[i+1] 
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }

            // Largest element is fixed, 
            // recur for remaining array 
            Call++;
            BubbleSort( arr, n - 1 );
        }

        public static int[] Random( int length )
        {
            int[] vector = new int[length];

            Random r = new Random();

            for( int i = 0; i < length; i++ )
            {
                vector[i] = r.Next( 0, 100 );
            }

            return vector;
        }

        public static void Main( string[] args )
        {
            string size = Console.ReadLine();

            int[] vec = Random( Int32.Parse(size) );

            Console.WriteLine( DateTime.Now.ToString( "dd/MM/yyyy HH:mm:ss.fff") );

            BubbleSort(vec, vec.Length);

            Console.WriteLine( DateTime.Now.ToString( "dd/MM/yyyy HH:mm:ss.fff" ) );

            Console.WriteLine("Chamandas: {0}", Call);

            Console.ReadLine();

        }
    }
}
