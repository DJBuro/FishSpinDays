namespace FishSpinDays.Common.Admin.ViewModels
{
    using FishSpinDays.Common.Identity.ViewModels;
    using System.Collections.Generic;

    public class UserDetailsViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }
       
        public string Email { get; set; }

        public ICollection<PublicationConciseViewModel> Publications { get; set; }
    }
}
