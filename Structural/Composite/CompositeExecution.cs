namespace DesignPatterns.Structural.Composite
{
    public class CompositeExecution
    {
        public static void Execute()
        {
            var registerValidation = new Message("O cadastro não foi realizado!");

            var formError = new Message("O usuário informou um name inválido");

            var sizeFormError = new InputFormMessage("O name precisa possuir mais de 2 caracteres");
            var nameFormError = new InputFormMessage("O name não pode possuir numeros");

            formError.AddChild(sizeFormError);
            formError.AddChild(nameFormError);

            registerValidation.AddChild(formError);

            var domainError = new Message("Problemas ao processar o cadastro de usuario");

            var cpfDomainError = new DomainMessage("O CPF informado está em uso!");
            var emailDomainError = new DomainMessage("O Email informado está em uso!");

            domainError.AddChild(cpfDomainError);
            domainError.AddChild(emailDomainError);

            registerValidation.AddChild(domainError);

            registerValidation.ShowMessages(2);
        }
    }
}