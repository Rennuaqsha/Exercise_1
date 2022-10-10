class program
{
    //Mendeklarasikan array int dengan ukuran 65
    private int[] RAS = new int[65];

    //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan 
    private int n;

    public void read()
    {
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
    }
}