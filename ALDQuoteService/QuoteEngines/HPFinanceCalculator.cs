namespace ALDQuoteService.QuoteEngines
{
    public class HPFinanceCalculator : FinanceCalculatorBase
    {
        /// <summary>
        /// Calculates the APR (interest rate) applicable to specified contract term.
        /// </summary>
        /// <param name="termMonths">The contract term in months</param>
        /// <returns></returns>
        public override decimal GetAnnualPercentageRate(short termMonths)
        {
            // TODO - Implement specific APR calculation for HP contracts
            return base.GetAnnualPercentageRate(termMonths);
        }
    }
}