using System;

namespace MediatorExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Formulario formulario = new Formulario();
            formulario.agregaControl(new ZonaInformacion("Nombre"));
            formulario.agregaControl( new ZonaInformacion("Apellidos"));
            PopupMenu menu = new PopupMenu("Coprestatario");
            menu.AgregaOpcion("sin coprestatario");
            menu.AgregaOpcion("con coprestatario");
            formulario.agregaControl(menu);
            formulario.menuCoprestatario = menu;
            Boton boton = new Boton("OK");
            formulario.agregaControl(boton);
            formulario.botonOk = boton;
            formulario.AgregaControlCoprestatario(new ZonaInformacion("Nombre del coprestatario"));
            formulario.AgregaControlCoprestatario(new ZonaInformacion("Apellido del coprestatario"));
            formulario.Informa();
        }
    }
}
