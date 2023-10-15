
Humano defensor = new Humano("Atacado");
Humano luchador = new Humano("Atacante", 5, 5, 5, 150);
Humano agresor = new Humano(luchador);

Console.WriteLine("");
Console.WriteLine($"La salud del defensor antes de ser atacado: {defensor.Salud}");
Console.WriteLine("");
defensor.Salud = agresor.Ataque(defensor);
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
    Humano Agresor;
    
    public Humano(string n, int f = 3, int i = 3, int d = 3, int s = 100)
    {
        Nombre = n;
        Fuerza = f;
        Inteligencia = i;
        Destreza = d;
        Salud = s;
    }

    public Humano(Humano atacante)
    {
        Agresor = atacante;
    }

    public int Ataque(Humano atacado)
    {
        int dañoAgresor = 3 * Agresor.Fuerza;
        int dañoRecibido = atacado.Salud - dañoAgresor;

        return dañoRecibido;
    }
}