/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 11/9/2025
 * Hora: 19:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of EstrategiaPorPromedio.
	/// </summary>
	public class EstrategiaPorPromedio : EstrategiaDeComparacion
	{
		public bool sosMayor(Alumno a, Alumno b){
			
			return a.getPromedio() > b.getPromedio();
		}
		
		public bool sosIgual(Alumno a, Alumno b){
			
			return a.getPromedio() == b.getPromedio();
		}
		
		public bool sosMenor(Alumno a, Alumno b){
			
			return a.getPromedio() < b.getPromedio();
		}
		
	}
}
