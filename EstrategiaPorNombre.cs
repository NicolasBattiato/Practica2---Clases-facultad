/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 11/9/2025
 * Hora: 19:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of EstrategiaPorNombre.
	/// </summary>
	public class EstrategiaPorNombre : EstrategiaDeComparacion
	{
		public bool sosMayor(Alumno a, Alumno b){
	        return string.Compare(a.getNombre(), b.getNombre()) > 0;
	    }
	    
	    public bool sosIgual(Alumno a, Alumno b){
	        return a.getNombre() == b.getNombre();
	    }
	    
	    public bool sosMenor(Alumno a, Alumno b){
	        return string.Compare(a.getNombre(), b.getNombre()) < 0;
	    }
	}
}
