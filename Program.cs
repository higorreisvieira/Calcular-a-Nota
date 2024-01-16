using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNotaAluno
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// O software irá solicitar 4 notas de um aluno para o professor. Após isso, o programa irá informar a média da nota e se o mesmo foi aprovado ou reprovado no sistema.

			int n1, n2, n3, n4;

			// Solicitando a 1° nota para o professor
			Console.WriteLine("Por favor, informe a 1° nota do aluno: "); 
			n1 = Convert.ToInt16(Console.ReadLine());

			// Solicitando a 2° nota para o professor
			Console.WriteLine("Digite a 2° nota do aluno: ");
			n2 = Convert.ToInt16(Console.ReadLine());

			// Solicitando a 3° nota para o professor
			Console.WriteLine("Digite a 3° nota do aluno: ");
			n3 = Convert.ToInt16(Console.ReadLine());

			// Solicitando a 4 e última nota ao professor
			Console.WriteLine("Digite a 4° nota do aluno: ");
			n4 = Convert.ToInt16(Console.ReadLine());
			

			int media = (n1 + n2 + n3 + n4) / 4;

			if (media >= 5)
			{
				Console.WriteLine("APROVADO!");
			} else
			{
				Console.WriteLine("REPROVADO!");
			}
			
			Console.ReadLine();

		}
	}
}
