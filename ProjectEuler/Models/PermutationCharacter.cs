namespace ProjectEuler.Models
{
    /// <summary>
    /// Simple class that holds a character and with a bool to let us know if it is available
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