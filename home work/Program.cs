void Qidiruv(List<string> topilganmalumot, string Path, string FaylNomi)
{
    string[] Fayllar = Directory.GetFiles(Path);
    foreach (string f in Fayllar)
    {
        string[] filenomi = f.Split('\\');
        if (filenomi[filenomi.Length - 1] == FaylNomi)
            topilganmalumot.Add(f);
    }

   
    string[] folders = Directory.GetDirectories(Path);
    foreach (string f in folders)
    {
       
        try
        {
            Qidiruv(topilganmalumot, f, FaylNomi);
        }
        catch { }
    }

}


Console.Write("Fayl nomini kiritng: ");
string FaylNomi = Console.ReadLine();
Console.WriteLine("......");

List<string> Topilmalar = new List<string>();
DriveInfo[] Disklar = DriveInfo.GetDrives();
for (int i = 0; i < Disklar.Length; i++)
{
    Qidiruv(Topilmalar, Convert.ToString(Disklar[i]), FaylNomi);
}

Console.WriteLine("resoult: ");
foreach (string f in Topilmalar)
    Console.WriteLine(f);
