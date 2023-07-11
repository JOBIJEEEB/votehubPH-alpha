using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace VoteHub_PH
{
    internal class VoterID
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    internal class Voter
    {
        public List<VoterID> voterProfile;
        public Voter() 
        {
            voterProfile = new List<VoterID>();

            VoterID voter1 = new VoterID
            {
                Username = "Santelmo",
                Password = "imsohot"
            };
            VoterID voter2 = new VoterID
            {
                Username = "TallanoDigger",
                Password = "tiger!unity!"
            };
            VoterID voter3 = new VoterID
            {
                Username = "Simoun",
                Password = "hindiakosiIbarrapramis"
            };
            VoterID voter4 = new VoterID
            {
                Username = "MannyPacquiao",
                Password = "EdiTipaklong!"
            };
            VoterID voter5 = new VoterID
            {
                Username = "MariaClara ",
                Password = "Ibarra143"
            };
            VoterID voter6 = new VoterID
            {
                Username = "Awra",
                Password = "ihatecctv"
            };
            VoterID voter7 = new VoterID
            {
                Username = "Tanggeroar",
                Password = "BeerBellyBeast7"
            };
            VoterID voter8 = new VoterID
            {
                Username = "Narda",
                Password = "lipad@456"
            };
            VoterID voter9 = new VoterID
            {
                Username = "HindiakosiRizalpramis ",
                Password = "MiUltimoAdios"
            };
            VoterID voter10 = new VoterID
            {
                Username = "dabongbongevader",
                Password = "ihatetax"
            };
            VoterID voter11 = new VoterID
            {
                Username = "LapuLapu",
                Password = "FishsaMactan"
            };
            VoterID voter12 = new VoterID
            {
                Username = "LatoLato",
                Password = "i=0, i<100, taktak++"
            };
            VoterID voter13 = new VoterID
            {
                Username = "HeneralLuna",
                Password = "BayanOSarili"
            };
            VoterID voter14 = new VoterID
            {
                Username = "AlexandraTrese",
                Password = "imongLakan"
            };
            VoterID voter15 = new VoterID
            {
                Username = "DaDu30",
                Password = "ihateDrugs"
            };
            VoterID voter16 = new VoterID
            {
                Username = "Imaw",
                Password = "pashnea69"
            };
            VoterID voter17 = new VoterID
            {
                Username = "motherSisa",
                Password = "crispyBasil"
            };
            VoterID voter18 = new VoterID
            {
                Username = "DambuDamaso",
                Password = "tinolalover"
            };
            VoterID voter19 = new VoterID
            {
                Username = "_xX-TVJ-Xx_",
                Password = "_spoliariumXD_"
            };
            VoterID voter20 = new VoterID()
            {
                Username = "LeaSalonga",
                Password = "MissSaigon"
            };

            voterProfile.Add(voter1);
            voterProfile.Add(voter2);
            voterProfile.Add(voter3);
            voterProfile.Add(voter4);
            voterProfile.Add(voter5);
            voterProfile.Add(voter6);
            voterProfile.Add(voter7);
            voterProfile.Add(voter8);
            voterProfile.Add(voter9);
            voterProfile.Add(voter10);
            voterProfile.Add(voter11);
            voterProfile.Add(voter12);
            voterProfile.Add(voter13);
            voterProfile.Add(voter14);
            voterProfile.Add(voter15);
            voterProfile.Add(voter16);
            voterProfile.Add(voter17);
            voterProfile.Add(voter18);
            voterProfile.Add(voter19);
            voterProfile.Add(voter20);
        }
        public bool VerifyVoterProfile(string username, string password) 
        {
            foreach (var voter in voterProfile) 
            {
                if (username == voter.Username && password == voter.Password)
                {
                    return true;
                }
            }
            return false;
        }
        /* FOR FUTURE PATCH UPDATES, MAY ADD THE FEATURE TO CREATE A VOTER'S PROFILE
        public VoterID CreateProfile(string username, string password)
        {
            VoterID voter = new VoterID
            {
                Username = ($"{username}"),
                Password = ($"{password}")
            };
            return voter;
        }
        */
    }
}
