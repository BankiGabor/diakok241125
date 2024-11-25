namespace diakok241125;

internal class Diakok
{
    public int Kor { get; set; }
    public Szakirany Szak { get; set; }
    public string Nev { get; set; }
    public double Atlag { get; set; }
    public List<string> Tantargyak { get; set; }

    public Diakok(string neve, int eletkora, Szakirany szak, double atlag, List<string> tantargyak = null)
    {
        Nev = neve;
        Kor = eletkora;
        Szak = szak;
        Atlag = atlag;
        Tantargyak = tantargyak ?? new List<string>();
    }

    public Diakok(string neve, int eletkora, Szakirany szak, double atlag, string tantargy1, string tantargy2)
        : this(neve, eletkora, szak, atlag, new List<string> { tantargy1, tantargy2 })
    { }

    public Diakok(string neve, int eletkora, Szakirany szak, double atlag, string tantargy)
        : this(neve, eletkora, szak, atlag, new List<string> { tantargy })
    { }

    public Diakok(string neve, Szakirany szak)
        : this(neve, 18, szak, 3.0, new List<string>())
    { }

    public override string ToString()
    {
        return $"{Nev}, Életkor: {Kor}, Szak: {Szak}, Átlag: {Atlag}, Tantárgyak: {string.Join(", ", Tantargyak)}";
    }
}
