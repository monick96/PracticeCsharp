using System;
using System.Collections.Generic;

namespace Ejercicio1Persona 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //clase persona
            Console.WriteLine("Clase Persona");

            Persona pedro = new Persona("456978","Pedro","Pedro",18,'M');

            pedro.saludar();

            pedro.obtenerNombreYApellido();

            pedro.modificarEdad(19);

            //clase usuario
            //creo una lista para almacenar usuarios
            List<Usuario> listaUsuarios = new List<Usuario> ();

            Usuario user1 = new Usuario("pedro","pedro.com","cocacola");

            Usuario user2 = new Usuario("pepe","pepe.com","gomitas");

            listaUsuarios.Add(user1);
        
            listaUsuarios.Add(user2);

            //buscar si existe el usuario 
            foreach (Usuario user in listaUsuarios)
            {
                //usuario que no existe
                //user.existeUsuario("juan");

                //usuario que existe
                user.existeUsuario("pedro");
                
            }
            
            //validar contraseña del user1
            user1.passwordValida("cocacola");

            //inicio de sesion incorrecto
            //si le paso al user 1 una contraseña incorrecta, envia un msje de error
            user1.iniciarSesion(listaUsuarios,"pedro","coca");
          
            //inicio de sesion correcto
            user1.iniciarSesion(listaUsuarios,"pedro","cocacola");


        }
    }

    public class Persona
    {
        //Atributos
        public string dni;
        public string nombre;
        public string apellido;
        public int edad;
        public char sexo;

        //Metodos
        //constructor
        public Persona (string dniParam, string nombreParam, string apellidoParam, int edadParam, char sexoParam)
        {
            dni = dniParam;

            nombre = nombreParam;

            apellido = apellidoParam;

            edad = edadParam;

            sexo = sexoParam;

        }

        public Persona(){}

        public void saludar () 
        {
            System.Console.WriteLine($"Hola, soy {nombre}");
        }

        public void obtenerNombreYApellido()
        {
            System.Console.WriteLine($"Nombre: {nombre}");

            System.Console.WriteLine($"Apellido: {apellido}");

        }

        public void modificarEdad(int edadParam)
        {
            System.Console.WriteLine($"Edad: {edad}");

            edad = edadParam;

            System.Console.WriteLine($"Edad modificada a: {edad}");

        }


    }

    public class Usuario:Persona
    {
        //Atributos
        public string nombreUsuario;
        public string email;
        public string password;

        //Metodos
        public Usuario(string nombreUsuarioParam, string emailParam,string passwordParam ){

            registrarse(nombreUsuarioParam, emailParam, passwordParam );
        }

        public Usuario(){}

        public void registrarse(string nombreUsuarioParam, string emailParam,string passwordParam )
        {
            System.Console.WriteLine("Registro usuario");
            
            nombreUsuario = nombreUsuarioParam;

            email = emailParam;

            password = passwordParam;

            System.Console.WriteLine("Usuario registrado");
 
        }

        /* metodo que recibe lista de usuarios guardados desde el main
        *busca en la lista de usuarios el nombre ingresado por parametro
        *si lo encuentra se corta el bucle, guarda el user
        * compara con la contraseña recibida por parametro 
        con la contraseña del usuario recuperado de la lista guardada
        */
        public void iniciarSesion(List<Usuario> listaUsuarios, string nombreUsuarioParam, string passwordParam)
        {
            bool encontrado = false;

            Usuario usuarioEncontrado = null;

            foreach (Usuario user in listaUsuarios)
            {
                if (existeUsuario(nombreUsuarioParam))
                {
                    encontrado = existeUsuario(nombreUsuarioParam);
                    usuarioEncontrado = user;
                    break;
                }
            }

            if (encontrado)
            {
                if (usuarioEncontrado.password.Equals(passwordParam))
                {
                    System.Console.WriteLine("Ha iniciado Sesion");
                }

            }
            else
            {
                System.Console.WriteLine("Datos incorrectos... intente nuevamente");
            }


        }

        public bool existeUsuario(string emailOnombreUsuario)
        {
            bool encontrado = false;

            if (nombreUsuario.Equals(emailOnombreUsuario) || email.Equals(emailOnombreUsuario)){

                //System.Console.WriteLine("Usario encontrado");

                encontrado = true;

            }else
            {

                System.Console.WriteLine("Usuario no encontrado");

            }

            return encontrado;
        }

        public bool passwordValida(string passwordParam)
        {
            bool valido = false;
            if(password.Equals(passwordParam))
            {
                valido = true;
                System.Console.WriteLine("La contraseña es correcta");
            }else
            {
                System.Console.WriteLine("La contraseña es incorrecta");
            }

            return valido;
        }

    }
    
}