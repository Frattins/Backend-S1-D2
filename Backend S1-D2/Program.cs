using Backend_S1_D2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creazione dell'oggetto Persona
        Persona persona = new Persona("Mario", "Rossi", 30);
        Persona persona2 = new Persona("Davide", "Frattini", 25);

        // Utilizzo dei metodi per stampare i dati

        Console.WriteLine(persona.GetDettagli());
        Console.WriteLine(persona2.GetDettagli());
    }
}
