using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_P
{
    public static class Program
    {
        // Player choices dictionary
        private static readonly Dictionary<string, string> Choices = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {
            { "CatchWildPokemon", "1" },
            { "TrainPokemon", "2" },
            { "Exit", "3" }
        };

        // Yes or No dictionary
        private static readonly Dictionary<string, string> YesOrNo = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Yes", "Y" },
            { "No", "N" },
        };

        private static string Y = YesOrNo["Yes"];
        private static string N = YesOrNo["No"];
        private static string CatchWildPokemon = Choices["CatchWildPokemon"];
        private static string TrainPokemon = Choices["TrainPokemon"];
        private static string Exit = Choices["Exit"];

        private static PlayersCollection PlayersCollection = new PlayersCollection();
        private static GameState GameState = new GameState();
        private static bool IsGameOn;

        private static void Main(string[] args)
        {
            GameState.LoadGame(PlayersCollection);
            IsGameOn = true;
            Menu();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\nWhat do you want to do?\n");
            Console.WriteLine($"{CatchWildPokemon}. Catch wild pokemon");
            Console.WriteLine($"{TrainPokemon}. Train your pokemon in gym");
            Console.WriteLine($"{Exit}. Exit");
            Console.WriteLine("");
        }

        public static void Menu()
        {
            while (IsGameOn)
            {
                DisplayMenu();

                var choice = Console.ReadLine();

                // User input validation
                while (!Choices.Any(n => n.Value == choice))
                {
                    Console.WriteLine($"\nPlease type '{CatchWildPokemon}' or '{TrainPokemon}', or exit typing '{Exit}'.\n");
                    choice = Console.ReadLine();
                }

                // Exit game if user chooses so
                if (choice == Exit)
                {
                    GameState.SaveGame(PlayersCollection.GetPlayersCollection());
                    IsGameOn = false;
                    break;
                }

                // Otherwise check player's choice
                else
                {
                    PlayerChoice(choice);
                }
            }
            Console.WriteLine("");
        }

        private static void PlayerChoice(string choice)
        {
            // Catch Wild Pokemon
            if (choice == CatchWildPokemon)
            {
                // Check whether player has caught all wild pokemon
                if (PlayersCollection.IsCollectionCompleted())
                {
                    Console.WriteLine("\nYou've caught all wild pokemon!");
                }
                else
                {
                    ChoiceCatchWildPokemon();
                }
            }

            // Train Pokemon
            else if (choice == TrainPokemon)
            {
                // Check whether player has caught any pokemon yet
                if (PlayersCollection.IsCollectionEmpty())
                {
                    Console.WriteLine("\nYou haven't caught any pokemon yet!");
                }
                else
                {
                    ChoiceTrainPokemon();
                }
            }
        }

        private static void ChoiceCatchWildPokemon()
        {
            Console.WriteLine("\nTime to catch some pokemon!");

            while (true)
            {
                // Caught pokemon
                var caughtPokemon = PlayersCollection.GetRandomWildPokemon();
                Console.WriteLine($"\nYou caught {caughtPokemon.Name} lvl {caughtPokemon.Level}");

                // Display owned pokemon
                var displayOwnedPokemon = new List<string>();

                foreach (var pokemon in PlayersCollection.GetPlayersCollection())
                {
                    displayOwnedPokemon.Add(pokemon.Name + " lvl " + pokemon.Level);
                }

                Console.WriteLine("So far you have caught: " + string.Join(", ", displayOwnedPokemon));

                // Keep catching pokemon (?)
                Console.WriteLine("\nDo you want to keep catching pokemons? (Y/N)\n");

                var keepCatchingPokemon = Console.ReadLine().ToUpperInvariant();

                // User input validation
                while (!YesOrNo.Any(x => x.Value == keepCatchingPokemon))
                {
                    Console.WriteLine($"\nPlease type '{Y}' or '{N}'\n");
                    keepCatchingPokemon = Console.ReadLine().ToUpperInvariant();
                }

                // Go back to Menu if user chooses so
                if (keepCatchingPokemon.Equals(N))
                {
                    break;
                }

                // Check that there are wild pokemon left
                if (PlayersCollection.IsCollectionCompleted())
                {
                    Console.WriteLine("\nYou've caught all wild pokemon!");
                    break;
                }
            }
        }

        // Train Pokemon player choice
        private static void ChoiceTrainPokemon()
        {
            Console.WriteLine("\nTime to head to pokemon gym!");
            var trainPokemon = true;

            while (trainPokemon)
            {
                // Display owned pokemon
                var displayOwnedPokemon = new List<string>();

                foreach (var pokemon in PlayersCollection.GetPlayersCollection())
                {
                    displayOwnedPokemon.Add(pokemon.Name + " lvl " + pokemon.Level);
                }

                Console.WriteLine("\nOwned pokemon: " + string.Join(", ", displayOwnedPokemon));

                // Variables
                var isValidPokemon = false;
                var isTeamSet = false;
                var gymTeam = new List<Pokemon>();
                var displayGymTeam = new List<string>();

                // Add pokemon to Gym Team while it isn't set
                do
                {
                    // Gym team is automatically set if player has chosen 6 pokemon or it contains all their pokemon
                    if (gymTeam.Count == 6 || gymTeam.Count == PlayersCollection.GetPlayersCollection().Count)
                    {
                        break;
                    }

                    // Display current gym team if at least one pokemon has been added
                    if (gymTeam.Count > 0 && isValidPokemon)
                    {
                        // Display current gym team
                        Console.WriteLine("\nCurrent pokemon in your gym team: " + String.Join(", ", displayGymTeam));

                        // Team is set if player doesn't want to add another pokemon to their team
                        if (!AddAnotherPokemonToGymTeam())
                        {
                            isTeamSet = true;
                            break;
                        }
                    }

                    // Validate player's pokemon and add it to their team
                    do
                    {
                        isValidPokemon = HasPokemonBeenAddedToGymTeam(gymTeam, displayGymTeam);
                    }
                    while (!isValidPokemon);

                } while (!isTeamSet);

                // Ask player if they want to train again and if so, if they want the same team as last time
                do
                {
                    // Display trained pokemon
                    var displayTrainedPokemon = new List<string>();

                    foreach (var pokemon in gymTeam)
                    {
                        displayTrainedPokemon.Add(pokemon.Name + " lvl " + pokemon.Level);
                    }

                    Console.WriteLine($"\nYour pokemon [{string.Join(", ", displayTrainedPokemon)}] gained experience!");

                    // Increase pokemon experience points
                    foreach (var pokemon in gymTeam)
                    {
                        PokemonLevelSystem.IncreasePokemonExp(pokemon);

                        // Check whether any pokemon has leveled up
                        if (PokemonLevelSystem.HasPokemonLeveledUp(pokemon))
                        {
                            Console.WriteLine(pokemon.Name + " has leveled up!");
                        }
                        if (PokemonLevelSystem.HasPokemonReachedMaxLevel(pokemon))
                        {
                            Console.WriteLine(pokemon.Name + " has reached max level! ");
                        }
                    }

                    // Go back to Menu if user chooses so
                    if (!TrainAgain())
                    {
                        trainPokemon = false;
                        break;
                    }

                } while (TrainSameTeam());
            }
        }


        private static bool TrainAgain()
        {
            // Train pokemon in gym again (?)
            Console.WriteLine("\nDo you want to train again? (Y/N)\n");

            var keepTrainingPokemon = Console.ReadLine().ToUpperInvariant();

            // User input validation
            while (!YesOrNo.Any(x => x.Value == keepTrainingPokemon))
            {
                Console.WriteLine($"\nPlease type '{Y}' or '{N}'\n");
                keepTrainingPokemon = Console.ReadLine().ToUpperInvariant();
            }

            // Go back to Menu if Player chooses so
            if (keepTrainingPokemon.Equals(N))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private static bool TrainSameTeam()
        {
            // Train the same pokemon (?)
            Console.WriteLine("\nDo you want to train the same pokemon? (Y/N)\n");

            var trainSameTeam = Console.ReadLine().ToUpperInvariant();

            // User input validation
            while (!YesOrNo.Any(x => x.Value == trainSameTeam))
            {
                Console.WriteLine($"\nPlease type '{Y}' or '{N}'\n");
                trainSameTeam = Console.ReadLine().ToUpperInvariant();
            }

            if (trainSameTeam.Equals(N))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Returns whether player's chosen pokemon has been successfully added to their gym team
        private static bool HasPokemonBeenAddedToGymTeam(List<Pokemon> gymTeam, List<string> gymTeamInfo)
        {
            Console.WriteLine("\nType the name of a pokemon from your collection that you'd like to add to your gym team.");
            Console.WriteLine("You must add between 1 and 6 pokemon in your gym team.\n");

            var chosenPokemon = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(chosenPokemon))
            {
                return false;
            }

            chosenPokemon = chosenPokemon.Trim().ToLowerInvariant();
            chosenPokemon = chosenPokemon.First().ToString().ToUpper() + chosenPokemon.Substring(1);

            // Check that player's input is a valid owned pokemon
            if (!PlayersCollection.GetPlayersCollection().Any(p => p.Name == chosenPokemon))
            {
                return false;
            }
            else
            {
                // Check that the pokemon wasn't already added in player's gym team
                if (gymTeam.Any(p => p.Name == chosenPokemon))
                {
                    Console.WriteLine($"\nYou already added {chosenPokemon}.");
                    return false;
                }
                else
                {
                    // Add unique pokemon to Gym Team
                    var pokemon = PlayersCollection.GetPlayersCollection().SingleOrDefault(p => p.Name == chosenPokemon);
                    gymTeam.Add(pokemon);
                    gymTeamInfo.Add(pokemon.Name + " lvl " + pokemon.Level);

                    return true;
                }
            }
        }

        // Returns whether player wants to add another pokemon to their gym team
        private static bool AddAnotherPokemonToGymTeam()
        {
            Console.WriteLine("\nDo you want to add another pokemon to your gym team? (Y/N)\n");

            var addAnotherPokemonToGymTeam = Console.ReadLine().ToUpperInvariant();

            // User input validation
            while (!YesOrNo.Any(x => x.Value == addAnotherPokemonToGymTeam))
            {
                Console.WriteLine($"\nPlease type '{Y}' or '{N}'\n");
                addAnotherPokemonToGymTeam = Console.ReadLine().ToUpperInvariant();
            }

            if (addAnotherPokemonToGymTeam.Equals(N))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
