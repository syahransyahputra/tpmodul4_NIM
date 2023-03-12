public class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };
    
    public static int getKodePos(Kelurahan KELURAHAN)
    {
        int[] kodepos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodepos[(int)KELURAHAN];
    }
}

public class DoorMachine
{
    enum state { kunci, buka };

    public static void Main(string[] args)
    {
        Console.WriteLine("alamat: \nKelurahan " + KodePos.Kelurahan.Maleer + " KodePos " + KodePos.getKodePos(KodePos.Kelurahan.Maleer));
        Console.WriteLine("Kode Perintah: Kunci Pintu, Buka Pintu");

        state pintu = state.Terkunci;
        string Perintah = "Kunci Pintu";

        while (Perintah == "Kunci Pintu" || Perintah == "Buka Pintu")
        {
            Console.WriteLine(pintu);
            Console.Write("Masukkan Perintah: ");
            Perintah = Console.ReadLine();

            if (Perintah == "Buka Pintu")
            {
                pintu = state.buka;
            }
            else if (Perintah == "Kunci Pintu")
            {
                pintu = state.kunci;
            }
        }
    }
}