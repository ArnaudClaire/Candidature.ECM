namespace Candidature.ECM.Models;

public sealed record Candidat(
    string Nom,
    string Formation,
    string[] Competences,
    string[] Objectifs);
