/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 31/8/2025
 * Hora: 17:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public abstract class Persona : IComparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string n, int d)
		{
			this.nombre = n;
			this.dni = d;
		}
		
		public string getNombre(){
			
			return nombre;
		}
		
		public void setNombre(string nombre){
			
			this.nombre = nombre;
		}
		
		public int getDni(){
			
			return dni;
		}
		
		public void setDni(int dni){
			
			this.dni = dni;
			
		}
		
		public virtual bool sosIgual(IComparable c){
			
			return dni == ((Persona)c).getDni();
			
		}
		
		public virtual bool sosMenor(IComparable c){
			
			return dni < ((Persona)c).getDni();
		}
		
		public virtual bool sosMayor(IComparable c){
			
			return dni > ((Persona)c).getDni();
			
		}
		
		public override string ToString()
		{
		    return string.Format("[Persona: Nombre={0}, Dni={1}]", nombre, dni);
		}
		
		
		
	}
}
