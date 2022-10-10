using System.Security.AccessControl;

class program
{
    //Mendeklarasikan array int dengan ukuran 65
    private int[] rennu = new int[65];

    //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan 
    private int n;

    //fungsi atau method untuk menerima masukkan 
    public void read()
    {
        //menerima angka untuk menentukan banyaknya data yang disimpan pada array
        while (true)
        {
            Console.Write("masukkan banyaknya elemen pada arra: ");
            string s = Console.ReadLine();
            n = Int32.Parse(s);
            if (n <= 65)
                break;
            else
                Console.WriteLine("\nArray dapat mempunyai maksimal 65 elemen. \n");

        }
        Console.WriteLine("");
        Console.WriteLine("-----------------------");
        Console.WriteLine(" masukkan elemen array ");
        Console.WriteLine("-----------------------");

        //pengguna memasukkan elemen pada array
        for (int i = 0; i < n; i++)
        {
            Console.Write("<" + (i + 1) + ">");
            string s1 = Console.ReadLine();
            rennu[i] = Int32.Parse(s1);
        }
    }

    public void display()
    {
        //menampilkan arrat yang tersusun 
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(" Element array yang telah tersusun ");
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rennu[i]);
        }
    }

    public void inseertionsort() //fungsinya untuk mengurutkan angka dari data-data didalam array
    {
        
        for (int i = 1; i < n; i++) // for n - 1 passes
        {
            for (int ras = 0; ras < n; ras++)
            {
                if (rennu[ras] > rennu[ras + 1]) //jika elemen tidak dalam urutan yang benar 
                {
                    // tukar elemen 
                    int temp;
                    temp = rennu[ras];
                    rennu[ras] = rennu[ras + 1];
                    rennu[ras + 1] = temp;
                }
            }
        }
    }

    static void main(string[] args)
    {
        //creating the object of the insertionsort
        program mylist = new program();

        //pemanggilan fungsi untuk menerima elemen array 
        mylist.read();

        //pemanggian fungsi untuk mengurutkan array
        mylist.inseertionsort();

        //pemanggilan fungsi untuk menampilkan array yang tersusun
        mylist.display();

        //exit
        Console.WriteLine("\n\n tekan tombol apa saja untuk keluar.");
        Console.Read();
    }
}