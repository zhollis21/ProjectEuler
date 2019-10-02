namespace ProjectEuler.Models
{
    /// <summary>
    /// Simple class to hold a character and a bool to let us know if we can pick it
    /// </summary>
    public class PermutationCharacter
    {
        public PermutationCharacter(char character)
        {
            Character = character;
        }

        public bool IsAvailable = true;

        public char Character;
    }
}