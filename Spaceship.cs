namespace StarFixGUI
{
    internal class Spaceship
    {
        private int repairProgress;
        private string statusMessage;

        public int RepairProgress
        {
            get { return repairProgress; }
            private set
            {
                if (value < 0)
                    repairProgress = 0;
                else if (value > 100)
                    repairProgress = 100;
                else
                    repairProgress = value;
            }
        }

        public string StatusMessage
        {
            get { return statusMessage; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    statusMessage = value;
                else
                    statusMessage = "Systems standing by.";
            }
        }

        public bool IsFullyRepaired
        {
            get { return repairProgress >= 100; }
        }

        public Spaceship()
        {
            RepairProgress = 0;
            StatusMessage = "Ship systems damaged. Repairs required.";
        }

        public void Repair()
        {
            RepairProgress += 20;

            if (RepairProgress >= 100)
                StatusMessage = "All systems restored. The ship is ready to return to Earth.";
            else
                StatusMessage = "Repair progress increased to " + RepairProgress + "%. Ship systems are stabilizing.";
        }

        public void ResetProgress(int correctAnswersLost)
        {
            if (correctAnswersLost < 0)
                correctAnswersLost = 0;

            RepairProgress -= correctAnswersLost * 20;

            if (RepairProgress == 0)
                StatusMessage = "Critical failure. Repair progress reset.";
            else
                StatusMessage = "Repair progress dropped to " + RepairProgress + "%. Systems need recovery.";
        }

        public void TakeDamage(int amount)
        {
            if (amount < 0)
                amount = 0;

            RepairProgress -= amount;

            if (RepairProgress == 0)
                StatusMessage = "The ship has taken severe damage.";
            else
                StatusMessage = "Warning: ship integrity reduced. Current repair progress: " + RepairProgress + "%.";
        }

        public string GetStatusMessage()
        {
            return StatusMessage;
        }

        public void ResetShip()
        {
            RepairProgress = 0;
            StatusMessage = "Ship systems damaged. Repairs required.";
        }
    }
}
