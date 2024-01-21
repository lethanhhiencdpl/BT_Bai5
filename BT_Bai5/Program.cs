using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char kytu;
            do
            {
                DisplayMenu();
                kytu = char.ToUpper(Console.ReadKey().KeyChar);

                switch (kytu)
                {
                    case '1':
                        BaiTap1();
                        break;
                    case '2':
                        BaiTap2();
                        break;
                    case '3':
                        BaiTap3();
                        break;
                    case '4':
                        BaiTap4();
                        break;
                    case '5':
                        BaiTap5();
                        break;
                    case '6':
                        BaiTap6();
                        break;
                    case '7':
                        BaiTap7();
                        break;
                    case 'E':
                        Console.WriteLine("\nChương trình kết thúc. Nhấn bất kỳ phím nào để thoát...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nLựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (kytu != 'E');
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\n MENU BÀI TẬP");
            Console.WriteLine("1. Hiển thị mảng và in đảo ngược");
            Console.WriteLine("2. Tính tổng các phần tử lẻ có tồn tại trong mảng");
            Console.WriteLine("3. Số lần xuất hiện của phần tử bất kỳ");
            Console.WriteLine("4. In ra các phần tử không bị trùng lặp");
            Console.WriteLine("5. Chia mảng ban đầu thành mảng chẵn và mảng lẻ");
            Console.WriteLine("6. Sắp xếp mảng theo thứ tự giảm dần.");
            Console.WriteLine("7. Tìm phần tử lớn thứ hai trong mảng");

            Console.WriteLine("E. Thoát chương trình");
            Console.Write("Chọn một chức năng hoặc E để thoát): ");
        }

        //Bài 1: Hiển thị mảng đã nhập và mảng đảo ngược ra màn hình.
        public static void BaiTap1()
        {
            Console.Write("Nhập số lượng phần tử mảng n= ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            //nhap phan tu cho mang
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Nhap vao phan tu thu {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //xuat mang - duyet mang
            Console.WriteLine("Mang vua nhap la:");
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }

        }
        //Bài 2: Tính tổng các phần tử lẻ có tồn tại trong mảng
        public static void BaiTap2()
        {
            Console.Write("Nhập số phần tử mảng n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write("Nhập số phần tử thứ {0} = ", i);
                array[i]=int.Parse(Console.ReadLine());

            }
            Console.WriteLine() ;

            //xuất mảng
            Console.WriteLine("Mang vua nhap la:");
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }

            //Tổng phần tử lẻ
            int S = 0;
            foreach (var item in array)
            {
                if (item%2 !=0)
                {
                    S += item;
                }
            }
            Console.WriteLine("Tổng phần tử lẻ là: {0}", S);
        }

        //Bài 3: Tìm số lần xuất hiện của phần tử bất kỳ được người dùng nhập từ bàn phím
        public static void BaiTap3()
        {

        }
        //Bài 4: In ra các phần tử không bị trùng lặp trong mảng.
        public static void BaiTap4()
        {

        }
        //Bài 5: Chia mảng ban đầu thành mảng chẵn và mảng lẻ.
        public static void BaiTap5()
        {

        }
        //Bài 6: Sắp xếp mảng theo thứ tự giảm dần. Lưu ý không được sử dụng hàm Sort và hàm Reverse mặc định của Array.
        public static void BaiTap6()
        {

        }
        //Bài 7: Tìm phần tử lớn thứ hai trong mảng
        public static void BaiTap7()
        {

        }
    }
}
