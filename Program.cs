using diccionariosCSharp;

internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<int, string> students = new Dictionary<int, string>();

        // Propiedad Count 
        Console.WriteLine($"Nunber of elements in the dictionary: {students.Count}");

        // .Add para agregar elementos a un diccionario
        // .Add method to add elements to a dictionary
        Console.WriteLine("\n Add elements to Dictionary: ");
        Console.WriteLine(MyFunctions.AddElement(students, 1, "William"));
        Console.WriteLine(MyFunctions.AddElement(students, 2, "Natalia"));
        Console.WriteLine(MyFunctions.AddElement(students, 3, "Samir"));
        Console.WriteLine(MyFunctions.AddElement(students, 4, "Nancy"));
        Console.WriteLine("Error when trying to add element with existing key: ");
        Console.WriteLine(MyFunctions.AddElement(students, 3, "Andres"));

        // Obtener el mensaje y el tipo de un error con try catch
        // get message and type of error with try catch
        Console.WriteLine("\n Get Error Information: ");
        try {
            students.Add(3, "Andres");
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
        Console.WriteLine("\n Dictionary ForEach");
        foreach (var elemento in students)
        {   
            Console.WriteLine(elemento);
        }

        // obtener las keys de un diccionario
        // get the keys from a dictionary
        Console.WriteLine("\n Get keys from a diccionary");
        Dictionary<int, string>.KeyCollection stuKeys = students.Keys;
        foreach (KeyValuePair<int, string> value in students)
        {   
            Console.WriteLine(value.Key);
        }

        // Comprobar si existe una key en un diccionario
        // Check if a key exists in a dictionary
        Console.WriteLine("\n Check if a key exists (2)");
        Console.WriteLine(MyFunctions.CheckKey(students, 2));


        // Comprobar si existe un valor en un diccionario
        // Check if a value exists in a dictionary
        Console.WriteLine("\n Check if a value exists (wilson)");
        Console.WriteLine(MyFunctions.CheckValue(students, "wilson"));


        // Metodo Remove -> Eliminar un elemento de un diccionario(utilizando su key)
        // Method Remove -> Remove item from a dictionary(using the key)
        Console.WriteLine("\n Trying to delete key thah does not exist(7)");
        Console.WriteLine(MyFunctions.RemoveElement(students, 7));
        Console.WriteLine(MyFunctions.RemoveElement(students, 3));
        Console.WriteLine("ForEach after remove the element..");
        foreach (var element in students)
        {
            Console.WriteLine(element);
        }

        
        // Metodo Clear -> Eliminar todos los elementos de un diccionario
        // Method Clear -> Remove all elements from a dictionary
        Console.WriteLine("\nRemove all elements from a dictionary");
        students.Clear();
        Console.WriteLine($"Numero de elementos despues de ejecutar Clear: {students.Count}");


    }

}