using Models;
using Busissnes;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// Endpoint que recibe nombre de usuario y contrase�a mediante el cuerpo de la solicitud (POST)
app.MapPost("/login", (string usuario, string pass) =>
{
    try
    {
        // Verificar que los par�metros no sean nulos
        if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(pass))
        {
            UsuarioBSSN userBssn = new UsuarioBSSN();

            // Crear una instancia de Usuario con los valores recibidos
            Usuario userLogin = new Usuario
            {
                Nombre = usuario,
                Pass = pass
            };

            // L�gica de validaci�n de usuario
            if (userBssn.Login(userLogin))
            {
                // Retornar cod 200
                return Results.Ok();
            }
            else
            {
                return Results.BadRequest("Usuario o contrase�a incorrectos");
            }
        }
        else
        {
            return Results.BadRequest("Los campos no pueden estar vac�os");
        }
    }
    catch (Exception ex)
    {
        return Results.Problem($"Error en el servidor: {ex.Message}");
    }
});

app.Run();

