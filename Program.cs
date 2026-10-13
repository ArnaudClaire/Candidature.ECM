using Candidature.ECM.Models;
using Candidature.ECM.Services;

var candidat = new Candidat(
    Nom: "Arnaud Claire",
    Formation: "Mastère Expert en Ingénierie du Logiciel – ISCOD",
    Competences:
    [
        "JavaScript / TypeScript",
        "Java / Spring Boot",
        "SQL / PostgreSQL",
        "Développement et maintenance d'applications métiers",
        "C# / .NET : connaissances à approfondir"
    ],
    Objectifs:
    [
        "Contribuer à la transformation digitale d'ECM",
        "Créer des outils simples et utiles aux équipes de production",
        "Progresser en C# / .NET aux côtés d'une équipe expérimentée"
    ]);

MotivationService.Presenter(candidat);
