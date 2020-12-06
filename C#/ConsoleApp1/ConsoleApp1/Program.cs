using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            ///変数
            int a = 123;
            var b = 456;
            const string c3 = "po";

            //配列
            int[] arr = new int[3];
            var list = new List<string>();
            list.Add("Red");
            Console.WriteLine(list[2]);

            //null(stringとobjectのみ)
            string str = null;
            //プリミティブな型には?をつける
            int? num = null;

            //制御構文
            int n = 50;
            if(n > 100)
            {
                Console.WriteLine("Big");
            }
            else
            {
                Console.WriteLine("Small");

            }

            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            var strings_list = new List<string>();
            foreach(string s in strings_list)
            {
                Console.WriteLine(s);
            }

            int nn= 0;
            while(nn < 10)
            {
                Console.WriteLine(nn);
                n++;

            }

            int n2 = 0;
            do
            {
                Console.WriteLine(n2);
                n++;
            } while (n < 10);

            int s = 0;
            switch (s)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("False");
                    break;
            }

            //goto文　ラベルの箇所に移動する
            for(int r = 1; r <= 10; r++)
            {
                Console.WriteLine("ループ処理開始");
                if(r == 5)
                {
                        goto LOOPEND;
                
                }
                LOOPEND:
                    Console.WriteLine("end")
            }

            //yield文　メソッドの処理を一時中断し、処理を呼び戻しもとに戻す
              static IEnumerator Iterator()
            {
                Console.Write("a");
                yield return null;

                Console.Write("b");
                yield return null;

                Console.Write("c");
                yield return null;

            }
            static void Main(string[] args)
            {
                //ループカウンタ
                int count = 0;
                IEnumerator iterator = Iterator();
                //この時点ではIteratorメソッドは実行されていない

                //次のyield文まで処理をすすめる
                //進めなくなったら偽を返すので、
                //真を返すときはループする
                while (iterator.MoveNext)
                {
                    //ループ回数を表示
                    Console.WriteLine(": {0}回目", ++count);
                }

                Console.ReadLine();
            }

            unchecked{
                //オーバーフローして-2147483648になる
                int overflaw = int.MaxValue;
                Console.WriteLine(overflaw + 1);
            }

            //checked
            //{
            //OverflowException例外が発生するようになる
            //   int overerror = int.MaxValue;
            //  Console.WriteLine(overerror + 1);
            // }


            //例外処理
            /// <summary>
            /// try
            /// {
            ///     if(エラーが発生したら){
            ///         throw new Exception("Message・・・");
            ///     }
            /// } 
            /// 
            /// catch
            /// {
            ///     例外を受け取る
            /// }
            /// 
            /// finally
            /// {
            ///     //例外の有無に限らず実行
            /// }
            /// 
            /// </summary>

            //クラス
        class Animal
        {
            public string type;
            //コンストラクタ
            public Animal(string type)
            {
                this.type = type;
            }

            //クラス名のメソッドはファイナライザとして呼び出される
            ~Animal()
            {
                //廃棄時の処理
            }

        }

        //インスタンスを生成
        Animal a1 = new Animal("dog");
        

               //構造体
        struct Point
        {
            public int x, y;
            
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        Point p1 = new Point(100, 200);





            //列挙型
            enum Color
        {
            Red,
            Green,
            Blue
        }
            enum Color2 : ushort
        {
            Orange = 10,
            Yellow = 20,
            Black = 30
        }

     
       
    }
}
}

