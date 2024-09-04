using RepasoObjetos;

object m = new object();
object m2 = new Mascota("nombre1","dueño1");
object V = new Veterinario(2, "nombreVeterinario");

object[] array = { m, m2, V };

foreach (object objeto in array)
{
    Console.WriteLine(objeto.ToString());
}