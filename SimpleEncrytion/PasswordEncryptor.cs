namespace SimpleEncrytion {
    public class PasswordEncryptor {
        public static void Main(string[] args) 
        {
            var mc = new PasswordEncryptor();

            Console.WriteLine($"Enter your password: ");
            //string pwd = Console.ReadLine();
            string pwd = "!Ab";

            string pwdEncrypted = mc.encryptPass(pwd);
            Console.WriteLine($"Encrypted Password: {pwdEncrypted}");
        }

        public string encryptPass(string pwd) {
            string[] pwdStrings = pwd.Split(new char[] { ' ' });

            List<string> pwdList = new List<string>();
            for (int i = 0; i < pwdStrings.Length; i++) {
                if (pwdStrings[i] != "" || pwdStrings[i] != " ") {
                    pwdList.Add(pwdStrings[i]);
                }
            }

            string ay = "ay";
            char[] ayChars = ay.ToCharArray();

            List<char[]> pwdCharList = new List<char[]>();

            for (int i = 0; i < pwdList.Count; i++) {
                char[] pwdChars = pwdList[i].ToCharArray();
                char[] encryptedChars = new char[pwdChars.Length + 2];
                bool isLast = false;
                bool isFirstSymbol = !char.IsLetterOrDigit(pwdChars[0]);
                bool isLastSymbol = !char.IsLetterOrDigit(pwdChars.Last());

                if (pwdChars.Length == 1) {
                    encryptedChars[0] = pwdChars[0];
                    encryptedChars[1] = ayChars[0];
                    encryptedChars[2] = ayChars[1];
                    pwdCharList.Add(encryptedChars);
                }
                else {
                    //Get index of first char that is not symbol 
                    int k = 0;
                    while (true) {
                        if (char.IsLetterOrDigit(pwdChars[k])) {
                            break;
                        }
                        else {
                            k++;
                        }
                    }

                    int j = 0;
                    while (j < pwdChars.Length - 1) {

                        //Check if current position is a symbol
                        if (!char.IsLetterOrDigit(pwdChars[j])) {
                            encryptedChars[j] = pwdChars[j];
                            //check if last
                            if (j == pwdChars.Length - 2) {
                                isLast = true;
                                encryptedChars[j + 1] = pwdChars[j + 1];
                                encryptedChars[j + 2] = ayChars[0];
                                encryptedChars[j + 3] = ayChars[1];
                                pwdCharList.Add(encryptedChars);
                                break;
                            }
                        }
                        else {
                            //Check if is not last char to change
                            if (j < pwdChars.Length - 2) {
                                //Check is if number or letter
                                if (char.IsLetterOrDigit(pwdChars[j + 1])) {
                                    //Check position Identation
                                    encryptedChars[j] = Char.IsUpper(pwdChars[j]) ? char.ToUpper(pwdChars[j + 1]) : encryptedChars[j] = char.ToLower(pwdChars[j + 1]);
                                }
                                else {
                                    //If next is a symbol, get next, keep symbol and check if last, if not j++
                                    //Check position Identation
                                    encryptedChars[j] = Char.IsUpper(pwdChars[j]) ? char.ToUpper(pwdChars[j + 2]) : encryptedChars[j] = char.ToLower(pwdChars[j + 2]);
                                    encryptedChars[j + 1] = pwdChars[j + 1];

                                    j++;

                                    //check if last
                                    if (j == pwdChars.Length - 2) {
                                        isLast = true;
                                    }

                                }

                            }
                            else {
                                isLast = true;
                            }

                            if (isLast) {
                                //Check if current position is not symbol
                                if (Char.IsLetterOrDigit(pwdChars[j])) {
                                    //Check if last char is not symbol
                                    if (char.IsLetterOrDigit(pwdChars[j + 1])) {

                                        encryptedChars[j] = Char.IsUpper(pwdChars[j])
                                            ? char.ToUpper(pwdChars[j + 1])
                                            : char.ToLower(pwdChars[j + 1]);

                                        //First char that is not symbol
                                        encryptedChars[j + 1] = char.IsUpper(encryptedChars[j + 1])
                                            ? char.ToUpper(pwdChars[k])
                                            : char.ToLower(pwdChars[k]);

                                        encryptedChars[j + 2] = ayChars[0];
                                        encryptedChars[j + 3] = ayChars[1];
                                    }
                                    else {
                                        //First char that is not symbol
                                        encryptedChars[j] = Char.IsUpper(pwdChars[j])
                                            ? char.ToUpper(pwdChars[k])
                                            : char.ToLower(pwdChars[k]);


                                        encryptedChars[j + 1] = ayChars[0];
                                        encryptedChars[j + 2] = ayChars[1];
                                        encryptedChars[j + 3] = pwdChars[j + 1];
                                    }
                                }
                                else {
                                    encryptedChars[j] = pwdChars[j];
                                    encryptedChars[j + 1] = Char.IsUpper(pwdChars[j]) ? char.ToUpper(pwdChars[0]) : char.ToLower(pwdChars[0]);

                                    encryptedChars[j + 2] = ayChars[0];
                                    encryptedChars[j + 3] = ayChars[1];
                                }

                                pwdCharList.Add(encryptedChars);
                            }
                        }
                        j++;
                    }
                }


                
            }

            List<string> encryptedList = new List<string>();
            foreach (char[] chars in pwdCharList) {
                encryptedList.Add(new string(chars));
            }

            return string.Join(" ", encryptedList);
        }


    }
}