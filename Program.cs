using ClasePelicula;

ClassPelicula miPelicula =new ClassPelicula();

Console.WriteLine("Ïngresa el nombre de la pelicula: ");
miPelicula.Nombre = Console.ReadLine();
Console.WriteLine("Ïngresa el nombre del director: ");
miPelicula.Director = Console.ReadLine();
Console.WriteLine("Ïngresa el año de liberacion: ");
miPelicula.AnioDeLiberacion = int.Parse(Console.ReadLine());
Console.WriteLine("Ïngresa el Genero: ");
miPelicula.Genero = Console.ReadLine();
Console.WriteLine("Ïngresa el presupuesto de la pelicula: ");
miPelicula.Presupuesto =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ïngresa la recaudacion total: ");
miPelicula.Recaudacion =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingresa la Duracion total en minutos de la pelicula: ");
miPelicula.DuracionEnMinutos = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("El nombre de tu pelicula es: " + miPelicula.Nombre + " El nombre del director: "+miPelicula.Director+" El año de liberacion" +
    " de la pelicula fue: " + miPelicula.AnioDeLiberacion + " Genero: " +miPelicula.Genero +" Presupuesto en dolares: "+miPelicula.Presupuesto+" Recaudacion en dolares: " +
    miPelicula.Recaudacion+" Duracion en minutos: " + miPelicula.Recaudacion);


if (miPelicula.EsDeTerror())
{
    Console.WriteLine("Efectivamente es de terror");
}
else
{
    Console.WriteLine("Realmente no es de terror");
}