using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System;


namespace DojoSurveyModels.Models

{
    public class Survey
    {
        [Required(ErrorMessage= "Name needs more than 2 Letters")]
        [MinLength(2)]
        public string Name {get;set;}

        [Required(ErrorMessage ="Need a Location to submit.")]
        public string Location{get;set;}

        [Required(ErrorMessage = "Need a Language to submit")]
        public string Language{get;set;}
        
        [Required(ErrorMessage = "Longer Comment")]
        [MinLength(20)]
        public string Comment{get;set;}
    }
}