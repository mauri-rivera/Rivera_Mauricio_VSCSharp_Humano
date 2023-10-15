
Humano agresor = new Humano("Atacante", 5, 5, 5, 150, 75);
Humano defensor = new Humano("Atacado");

Console.WriteLine("");
Console.WriteLine($"La salud del defensor antes de ser atacado: {defensor.Salud}");
Console.WriteLine("");
defensor.Salud = agresor.Ataque(defensor, agresor);
Console.WriteLine($"La salud del defensor después de ser atacado: {defensor.Salud}");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");

class Humano
{
    public string Nombre { get; set; }
    public int Fuerza { get; set; }
    public int Inteligencia { get; set; }
    public int Destreza { get; set; }
    public int Salud { get; set; }
    public int Resistencia { get; set; }

    public Humano(string n, int f = 3, int i = 3, int d = 3, int s = 100)
    {
        Nombre = n;
        Fuerza = f;
        Inteligencia = i;
        Destreza = d;
        Salud = s;
    }

    public Humano(string n, int f, int i, int d, int s, int r = 50)
    {
        Nombre = n;
        Fuerza = f;
        Inteligencia = i;
        Destreza = d;
        Salud = s;
        Resistencia = r;
    }

    public int Ataque(Humano atacado, Humano atacante)
    {
        int danioAgresor = 3 * atacante.Fuerza;
        int danioRecibido = atacado.Salud - danioAgresor;

        return danioRecibido;
    }
}


