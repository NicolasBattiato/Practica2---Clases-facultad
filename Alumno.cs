/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 31/8/2025
 * Hora: 17:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_2
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona, IComparable
	{
		private int legajo;
		private int promedio;
		EstrategiaDeComparacion estrategia;
		
		public Alumno(string nombre, int dni, int legajo, int promedio): base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			this.estrategia = new EstrategiaPorPromedio();
		}
		
		public int getLegajo(){
			
			return legajo;
		}
		
		public void setLegajo(int legajo){
			
			this.legajo = legajo;
		}
		
		public int getPromedio(){
			
			return promedio;
		}
		
		public void setPromedio(int promedio){
			
			this.promedio = promedio;
		}
		
		
		public void setEstrategia(EstrategiaDeComparacion nuevaEstrategia){
			this.estrategia = nuevaEstrategia;
		}
		
		override public bool sosIgual(IComparable c){
			
			return this.estrategia.sosIgual(this,(Alumno)c);
			
		}
		
		override public bool sosMenor(IComparable c){
			
			return this.estrategia.sosMenor(this,(Alumno)c);
			
		}
		
		override public bool sosMayor(IComparable c){
			
			return this.estrategia.sosMayor(this,(Alumno)c);
			
		}
		
		// ---------------------------------------------------------------
		
		override public string ToString() { return base.ToString() + string.Format("[Alumno: Legajo={0}, Promedio={1}]", legajo, promedio); }
		
		
		
	}
}
