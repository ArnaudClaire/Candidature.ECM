using Candidature.ECM.Models;

namespace Candidature.ECM.Services;

public static class MotivationService
{
    public static void Presenter(Candidat candidat)
    {
        Console.WriteLine("=== CANDIDATURE ECM ===\n");
        Console.WriteLine($"Candidat : {candidat.Nom}");
        Console.WriteLine($"Formation : {candidat.Formation}\n");
        Console.WriteLine("Compétences :");
        foreach (var competence in candidat.Competences)
            Console.WriteLine($"- {competence}");
        Console.WriteLine("\nObjectifs :");
        foreach (var objectif in candidat.Objectifs)
            Console.WriteLine($"- {objectif}");
        Console.WriteLine("\nStatut : Disponible pour échanger");
    }
}
