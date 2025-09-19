/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 11/9/2025
 * Hora: 19:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of EstrategiaDeComparacion.
	/// </summary>
	public interface EstrategiaDeComparacion
	{
		bool sosMayor(Alumno a1, Alumno a2);
		bool sosIgual(Alumno a1, Alumno a2);
		bool sosMenor(Alumno a1, Alumno a2);
	}
}
