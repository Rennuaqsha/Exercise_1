class program
{
    //Mendeklarasikan array int dengan ukuran 65
    private int[] Rennu = new int[65];

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
            Rennu[i] = Int32.Parse(s1);
        }
    }

}