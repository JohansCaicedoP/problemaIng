using System;

//Version 1.0
namespace IngPRoblema
{ /*
        INT[] SUMA_?_?([]POSIBLES)
     */

    class Program
    {
        int[] recalc(int[]pesos) {
            int[] newPesos = new int[10];
            for (int I = 0; I < 10; I++) {
              int[] posibles =  SUMA_a_b(pesos);

            }


            return newPesos;
        }
        public void print(int index)
        {
            if (index >= 10)
            {
                Console.Write(index + "000            ");
            }
            else
            {
                Console.Write(index + "000             ");
            }

        }
        void testCase(int[] arrA, int[] arrB, int result) {            
            for (int i = 0; i < 10; i++) {              
               if(result == (arrA[i] + arrB[i]))
                    Console.WriteLine("[" + i + "]  !");                    
                else
                    Console.WriteLine("[" + i + "]  X");
            }
        }
        void logMethod(int[] vector, string label) {
           // Console.WriteLine("Posibles valores para: "+label);
            //for (int i = 0; i < vector.Length; i++) Console.WriteLine(vector[i]);
        }
        int[] SUMA_a_b(int[] POSIBLES_A) {
            
            int[] POSIBLES_B = new int [10];          
            
            for (int i = 0; i<POSIBLES_A.Length; i++) POSIBLES_B[i] = 11 - POSIBLES_A[i];

            logMethod(POSIBLES_B, "b");                       
            return POSIBLES_B;
        }

        int[] SUMA_b_c(int[] POSIBLES_B) {
            int[] POSIBLES_C = new int[10];
            for (int i = 0; i < POSIBLES_B.Length; i++) POSIBLES_C[i] = 17 - POSIBLES_B[i];
            logMethod(POSIBLES_C, "c");
            return POSIBLES_C;
        }

        int[] SUMA_c_d(int[] POSIBLES_C)
        {
            int[] POSIBLES_D = new int[10];
            for (int i = 0; i < POSIBLES_C.Length; i++) POSIBLES_D[i] = 11 - POSIBLES_C[i];
            logMethod(POSIBLES_D, "d");
            return POSIBLES_D;
        }

        int[] SUMA_d_e(int[] POSIBLES_D)
        {
            int[] POSIBLES_E = new int[10];
            for (int i = 0; i < POSIBLES_D.Length; i++) POSIBLES_E[i] = 33 - POSIBLES_D[i];
            logMethod(POSIBLES_E, "e");
            return POSIBLES_E;
        }

        int[] SUMA_e_f(int[] POSIBLES_E)
        {
            int[] POSIBLES_F = new int[10];
            for (int i = 0; i < POSIBLES_E.Length; i++) POSIBLES_F[i] = 53 - POSIBLES_E[i];
            logMethod(POSIBLES_F, "f");
            return POSIBLES_F;
        }
        int[] SUMA_f_a(int[] POSIBLES_F) {
            int[] POSIBLES_A = new int[10];

            //Efectuando R2 y R3
            for (int i = 0; i < POSIBLES_F.Length; i++) POSIBLES_A[i] = 25 - POSIBLES_F[i];

            int[] resultado = new int[10];
            for (int i = 0; i < POSIBLES_A.Length; i++)
            {

                if (POSIBLES_F[i] +  POSIBLES_A[i] >= 25)
                {                    
                    resultado[i] = POSIBLES_A[i];
                }
            }
            logMethod(POSIBLES_A, "a ");
            return resultado;
        }
        static void Main(string[] args)
        {
            Program core = new Program();
            int[] posiblesA, posiblesB, posiblesC, posiblesD, posiblesE, posiblesF;
            /*
                Importante inicializacion !!!!
             */
            bool flag = true;
            do
            {
               

                int[] BigBang = new int[10];// "El origen de todo"

                for (int i = 0; i < 10; i++) BigBang[i] = i + 1;

                //core.logMethod(BigBang, "null");

                //Nodos
                

                //BigBang haciendo las veces de a
                posiblesB = core.SUMA_a_b(BigBang);
                posiblesC = core.SUMA_b_c(posiblesB);
                posiblesD = core.SUMA_c_d(posiblesC);
                posiblesE = core.SUMA_d_e(posiblesD);
                posiblesF = core.SUMA_e_f(posiblesE);
                posiblesA = core.SUMA_f_a(posiblesF);                            
                flag = false;
            } while (flag);//Solo permisible por un ciclo


            int suma = 0;
            bool _flag = true;
            int[] A, B, C, D, E, F;
            A = new int[10]; B = new int[10]; C = new int[10]; D = new int[10]; E = new int[10]; F = new int[10];
            int[] nuevos = new int[10];
            while (_flag) {
                if (nuevos[0] == 0)
                {
                    posiblesB = core.SUMA_a_b(posiblesA);
                    posiblesC = core.SUMA_b_c(posiblesB);
                    posiblesD = core.SUMA_c_d(posiblesC);
                    posiblesE = core.SUMA_d_e(posiblesD);
                    posiblesF = core.SUMA_e_f(posiblesE);
                    posiblesA = core.SUMA_f_a(posiblesF);
                }
                else {
                    posiblesB = core.SUMA_a_b(nuevos);
                    posiblesC = core.SUMA_b_c(posiblesB);
                    posiblesD = core.SUMA_c_d(posiblesC);
                    posiblesE = core.SUMA_d_e(posiblesD);
                    posiblesF = core.SUMA_e_f(posiblesE);
                    posiblesA = core.SUMA_f_a(posiblesF);

                }

                for (int OO = 0; OO < 10; OO++)
                {
                    if (posiblesA[OO] < 11 && posiblesA[OO] > 0) A[OO] = posiblesA[OO];
                }

               
                for (int QQ = 0; QQ < 10; QQ++)
                {
                    if (posiblesB[QQ] < 17 && posiblesB[QQ] > 0) B[QQ] = posiblesB[QQ];
                }

               
                for (int QQ = 0; QQ < 10; QQ++)
                {
                    if (posiblesC[QQ] < 11 && posiblesC[QQ] > 0) C[QQ] = posiblesC[QQ];
                }

                
                for (int QQ = 0; QQ < 10; QQ++)
                {
                    if (posiblesD[QQ] < 33 && posiblesD[QQ] > 0) D[QQ] = posiblesD[QQ];
                }

                
                for (int QQ = 0; QQ < 10; QQ++)
                {
                    if (posiblesE[QQ] < 33 && posiblesE[QQ] > 0) E[QQ] = posiblesE[QQ];
                }

               
                for (int QQ = 0; QQ < 10; QQ++)
                {
                    if (posiblesF[QQ] < 33 && posiblesF[QQ] > 0) F[QQ] = posiblesF[QQ];
                }
                

                Console.WriteLine("=============================================================================================================");
                    Console.WriteLine("Cocinera        Pintor        Plomero        Electricista        Carpintero        Albañil        Total");
                Console.WriteLine("=============================================================================================================");
                   
                for (int OO = 0;   OO < 10; OO++) {
                    int result = A[OO] + B[OO] + C[OO] + D[OO] + E[OO] + F[OO];
                   
                    nuevos[OO] = A[OO];

                    core.print(A[OO]);
                    core.print(B[OO]);
                    core.print(C[OO]);
                    core.print(D[OO]);
                    core.print(E[OO]);
                    core.print(F[OO]);
                    core.print(result);
                    Console.WriteLine();
                }
                for (int OO = 0; OO < 10; OO++)
                {
                    if (A[OO] >= 10) { Console.WriteLine();}
                }
                Console.WriteLine("--------------------------------------");
                Console.Write("Recalcular pesos? (Press any key to continue...)");
                Console.ReadKey(true);
                Console.Clear();
                if (suma == 100) _flag = false;
            }           
        }
                 
    }
}


