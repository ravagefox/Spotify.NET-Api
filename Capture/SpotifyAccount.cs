// Source: SpotifyAccount
/* 
   ---------------------------------------------------------------
                        CREXIUM ENTERTAINMENT
   ---------------------------------------------------------------

     The software is provided 'AS IS', without warranty of any kind,
   express or implied, including but not limited to the warrenties
   of merchantability, fitness for a particular purpose and
   noninfringement. In no event shall the authors or copyright
   holders be liable for any claim, damages, or other liability,
   whether in an action of contract, tort, or otherwise, arising
   from, out of or in connection with the software or the use of
   other dealings in the software.
*/

namespace Capture
{
    public sealed class SpotifyAccount
    {

        public static SpotifyAccount Default = new SpotifyAccount(bearerToken);

        private const string bearerToken = "BQB8zSMYIwdwCAZ-vnKB4-iaKbOYLv2JdeRXh13pqSj5u3lKYQs0osp8p0iH_9d_DK6HduKBifAcAaJkHTp807gJS8wdIF-xgUcslOu8O7V4cW_Unu6mSEx3A_rWBmr1xgrPJLnVnCbXg4FJqyIoQYy5-_wtn3e7RlHIPX0Bvljif6FruA6jjQ_zLzArKDcPqR3KR4ecBgELQ1ST_TZQBCSQPMB2zo5j84HVgB4sY3HpOCAmkHyEKupS8hk-BibTy9jUJX1hDrompfVG1aGVANMCXQi_W8Ux4NFD";

        public string AuthToken { get; set; }


        public SpotifyAccount(string oAuthToken)
        {
            this.AuthToken = oAuthToken;
        }
    }
}