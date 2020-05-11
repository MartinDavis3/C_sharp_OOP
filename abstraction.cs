using System;

namespace abstraction {
    class Program {
        abstract class SecretMessage {
            public void mySecretMessage() {
                Console.WriteLine("This is my secret message");
            }
        }
        class PublicMessage : SecretMessage {
            public void myPublicMessage() {
                Console.WriteLine("Everyone can see this message");
            }
        }
        static void MainAbstraction(string[] args) {
            PublicMessage myPubMsg = new PublicMessage();
            myPubMsg.myPublicMessage();
            myPubMsg.mySecretMessage();
        }
    }
}
