/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 11/9/2025
 * Hora: 19:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of EstrategiaPorDni.
	/// </summary>
	public class EstrategiaPorDni : EstrategiaDeComparacion
	{
		public bool sosMayor(Alumno a, Alumno b){
			
			return a.getDni() > b.getDni();
		}
		
		public bool sosIgual(Alumno a, Alumno b){
			
			return a.getDni() == b.getDni();
		}
		
		public bool sosMenor(Alumno a, Alumno b){
			
			return a.getDni() < b.getDni();
		}
	}
}
