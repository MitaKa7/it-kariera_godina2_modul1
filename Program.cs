using System.ComponentModel.Design;
using Microsoft.Data.SqlClient;

string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeSQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
void Initialize()
{

    string query = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U')
    BEGIN 
        CREATE TABLE Employees (
            Id INT IDENTITY PRIMARY KEY, 
            Name NVARCHAR(100) NOT NULL,
            Age INT NOT NULL,
            Description NVARCHAR(255)
        );
    END";
       
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        SqlCommand command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();
        Console.WriteLine("Table 'Employees' available!");
    }
}

Initialize();
string command = Console.ReadLine();
while (command != "end")
{
    if (command == "Add")
    {
        AddEmployee();
    }

    else if (command == "List")
    {
        GetEmployee();
        
    }
    else if (command == "Update")
    {
        updateEmployee();
    }
    
    else if (command == "Delete")
    {
        Delete();
    }
    command = Console.ReadLine();
    
}

void AddEmployee()
{
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    string description = Console.ReadLine();

    string query = @"INSERT INTO Employees (Name, Age, Description)
         VALUES(@Name, @Age, @Description)";
    using (SqlConnection connection = new SqlConnection(connectionString))

    {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@Age", age);
        command.Parameters.AddWithValue("@Description", description);
        connection.Open();
        int rowsaffected = command.ExecuteNonQuery();
        if (rowsaffected > 0)
        {

            Console.WriteLine("Employee added successfully!");
        }
        else
        {
            Console.WriteLine("Error adding employee");
        }
    }


}

void GetEmployee()
{
    string query = @"Select Id, Name, Age, Description FROM Employees";
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();
        using (SqlDataReader reader = command.ExecuteReader())
        {
            Console.WriteLine("Employees:");
            Console.WriteLine($" +{new string ('_', 100)}+");
            while (reader.Read())
            {
                Console.WriteLine($"|{reader["Id"], 5}|{reader["Name"], 20}|{reader["Age"], 3}|{reader["Description"], 70}|");
            }
        }
    }
}

void updateEmployee()
{
    int id = int.Parse(Console.ReadLine());
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    string description = Console.ReadLine();

    string query = @"UPDATE Employees Set Name = @Name, Age = @Age, Description = @Description WHERE Id = @Id";

    using (SqlConnection connection = new SqlConnection(connectionString))

    {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@Age", age);
        command.Parameters.AddWithValue("@Description", description);
        command.Parameters.AddWithValue("@Id", id);
        connection.Open();
        int rowsaffected = command.ExecuteNonQuery();
        if (rowsaffected > 0)
        {

            Console.WriteLine("Employee updated successfully!");
        }
        else
        {
            Console.WriteLine("Error updating employee");
        }

    }

}

void Delete()
{
    int id = int.Parse(Console.ReadLine());
    string query = "DELETE FROM Employees WHERE Id = @Id";

    using SqlConnection connection = new SqlConnection(connectionString);
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@Id", id);
    connection.Open();
    int rowsAffected = command.ExecuteNonQuery();
    if (rowsAffected > 0) 
        {
            Console.WriteLine("Employee added successfully!");
        }
    else
    {
        Console.WriteLine("Error deleting employee");
    }
}