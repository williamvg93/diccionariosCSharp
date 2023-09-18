internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<int, string> students = new Dictionary<int, string>();

        // Propiedad Count 
        Console.WriteLine($"Nunber of elements in the dictionary: {students.Count}");
        Console.WriteLine("\n");

        // .Add para agregar elementos a un diccionario
        // .Add method to add elements to a dictionary
        students.Add(1, "William");
        students.Add(2, "Natalia");
        students.Add(3, "samir");
        students.Add(4, "nancy");

        // Obtener el mensaje y el tipo de un error con try catch
        // get message and type of error with try catch
        try {
            students.Add(4, "New Student");
        }
        catch (Exception error) 
        {
            Console.WriteLine($"Mensaje de error : {error.Message}");
            Console.WriteLine($"GetType : {error.GetType()}");
            Console.WriteLine($"Data : {error.Data}");
            Console.WriteLine($"GetHashCode : {error.GetHashCode()}");
            Console.WriteLine($"GetObjectData : {error.GetObjectData}");
        }

        // recorrer un dicionario con ForEach
        Console.WriteLine("\n");
        foreach (var elemento in students)
        {   
            Console.WriteLine(elemento);
        }

        
        Console.WriteLine("\n");
        // obtener las keys de un diccionario
        // get the keys from a diccionary
        Dictionary<int, string>.KeyCollection stuKeys = students.Keys;
        foreach (KeyValuePair<int, string> value in students)
        {   
            Console.WriteLine(value.Key);
        }
    }

}