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
                        Console.WriteLine();
                        BaiTap1();
                        break;
                    case '2':
                        Console.WriteLine();
                        BaiTap2();
                        break;
                    case '3':
                        Console.WriteLine();
                        BaiTap3();
                        break;
                    case '4':
                        Console.WriteLine();
                        BaiTap4();
                        break;
                    case '5':
                        Console.WriteLine();
                        BaiTap5();
                        break;
                    case '6':
                        Console.WriteLine();
                        BaiTap6();
                        break;
                    case '7':
                        Console.WriteLine();
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
            //nhap mang
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
            //nhap mang
            Console.Write("Nhập số phần tử mảng n = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Nhập số phần tử thứ {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();

            //xuất mảng
            Console.WriteLine("Mang vua nhap la:");
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }
            int count=0;
            Console.WriteLine();
            // Nhập phần tử cần tìm
            Console.WriteLine("Nhập phần tử cần tìm: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==x)
                {
                    count++;
                }         
            }
            Console.WriteLine();

            // Hiển thị kết quả
            Console.WriteLine("Số lần xuất hiện của phần tử là: {0}", count);
        }
        //Bài 4: In ra các phần tử không bị trùng lặp trong mảng.
        public static void BaiTap4()
        {
            //nhap mang
            Console.Write("Nhập số phần tử mảng n = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Nhập số phần tử thứ {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();

            //xuất mảng
            Console.WriteLine("Mang vua nhap la:");
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            // Khởi tạo mảng để lưu trữ các phần tử không bị trùng lặp
            int[] mang_moi = new int[array.Length];
            int count = 0;

            // Duyệt mảng
            for (int i = 0; i < array.Length; i++)
            {
                // Kiểm tra xem phần tử hiện tại đã có trong mảng mang_moi chưa
                bool isDuplicated = false;
                for (int j = 0; j < count; j++)
                {
                    if (array[i] == mang_moi[j])
                    {
                        isDuplicated = true;
                        break;
                    }
                }
                // Nếu phần tử hiện tại chưa có trong mảng mang_moi
                if (!isDuplicated)
                {
                    mang_moi[count] = array[i];
                    count++;
                }
            }
            // Hiển thị kết quả
            Console.Write("Các phần tử không bị trùng lặp trong mảng là: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(mang_moi[i] + "  ");
            }
        }      
        //Bài 5: Chia mảng ban đầu thành mảng chẵn và mảng lẻ.
        public static void BaiTap5()
        {
            //nhap mang
            Console.Write("Nhập số phần tử mảng n = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Nhập số phần tử thứ {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();

            //xuất mảng
            Console.WriteLine("Mang vua nhap la:");
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            // chia mang
            // Khởi tạo mảng để lưu trữ các phần tử không bị trùng lặp
            int[] mang_chan = new int[array.Length];
            int[] mang_le = new int[array.Length];
            int count_chan = 0;
            int count_le = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    mang_chan[count_chan] = array[i];
                    count_chan++;
                }
                else
                {
                    mang_le[count_le] = array[i];
                    count_le++; 
                }
            }

            // Hiển thị mảng chẵn
            Console.WriteLine("Mảng chẵn là: ");
            for (int i = 0; i < count_chan; i++)
            {
                Console.WriteLine(mang_chan[i]+"   ");
            }

            Console.WriteLine("Mảng lẻ là: ");
            for (int i = 0; i < count_le; i++)
            {
                Console.Write(mang_le[i] + "   ");
            }

        }
        //Bài 6: Sắp xếp mảng theo thứ tự giảm dần. Lưu ý không được sử dụng hàm Sort và hàm Reverse mặc định của Array.
        public static void BaiTap6()
        {
            //nhap mang
            Console.Write("Nhập số phần tử mảng n = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Nhập số phần tử thứ {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();

            //xuất mảng
            Console.WriteLine("Mang vua nhap la:");
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            // Sắp xếp mảng giảm dần
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            //xuất mảng
            Console.WriteLine("Mang giảm dần là: ");
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
        }
        //Bài 7: Tìm phần tử lớn thứ hai trong mảng
        public static void BaiTap7()
        {

            //nhap mang
            Console.Write("Nhập số phần tử mảng n = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Nhập số phần tử thứ {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();

            //xuất mảng
            Console.WriteLine("Mang vua nhap la:");
            foreach (var item in array)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            // cách 1: Sắp xếp mảng giảm dần lấy phần tử [1]
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] < array[j])
            //        {
            //            int temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}
            ////xuất mảng
            //Console.WriteLine("Phần tử lớn thứ 2 trong mảng là:{0} ", array[1]);


            // Tìm phần tử lớn nhất trong mảng 
            int max = array[0];

            // Tìm phần tử lớn thứ hai trong mảng
            for (int i = 0; i < n; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            int secondMax = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] != max && (secondMax == -1 || array[i] > secondMax))
                {
                    secondMax = array[i];
                }
            }
            // Hiển thị kết quả
            Console.WriteLine("Phần tử lớn thứ hai trong mảng là: {0}", secondMax);

        }
    }
}
