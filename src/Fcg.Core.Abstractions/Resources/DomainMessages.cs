namespace Fcg.Core.Abstractions.Resources
{
    public static class DomainMessages
    {
        #region Usuario
        public static string UserNameRequired = "O nome do usuário é obrigatório.";
        public static string UserOldNameRequired = "O nome antigo do usuário é obrigatório.";
        public static string UserNewNameRequired = "O novo nome do usuário é obrigatório.";
        public static string UserEmailRequired = "O email do usuário é obrigatório.";
        public static string UserPasswordRequired = "A senha do usuário é obrigatória.";
        public static string UserPasswordConfirmationRequired = "A confirmação de senha do usuário é obrigatória.";
        public static string UserNameLengthInvalid = "O nome do usuário deve conter entre 3 e 20 caracteres.";
        public static string UserPasswordWeak = "A senha deve conter pelo menos 8 caracteres, incluindo letras maiúsculas, minúsculas, números e caracteres especiais.";
        public static string UserPasswordConfirmationMismatch = "A senha e a confirmação de senha devem ser iguais.";
        public static string UserMustBeActive = "O usuário deve estar ativo";
        public static string UserMustBeInactive = "O usuário deve estar inativo";
        public static string UserAlreadyDeactivated = "O usuário já foi desativado.";
        public static string UserOldEmailRequired = "O email antigo do usuário é obrigatório.";
        public static string UserOldEmailInvalid = "O email antigo do usuário é inválido.";
        public static string UserNewEmailRequired = "O novo email do usuário é obrigatório.";
        public static string UserNewEmailInvalid = "O novo email do usuário é inválido.";
        public static string UserOldPasswordRequired = "A senha antiga do usuário é obrigatória.";
        public static string UserOldPasswordWeak = "A senha antiga do usuário é fraca.";
        public static string UserNewPasswordRequired = "A senha nova do usuário é obrigatória.";
        public static string UserNewPasswordWeak = "A senha nova do usuário é fraca.";
        public static string UserNotFound = "O usuário não foi encontrado.";
        public static string AdminNotFound = "O administrador não foi encontrado.";
        public static string UserProfileDemoteInvalid = "O perfil do usuário não pode ser rebaixado para jogador, pois ele já é um jogador.";
        public static string UserProfilePromoteInvalid = "O perfil do usuário pode ser promovido para administrador, pois ele já é um administrador.";
        public static string InvalidCredentials = "Credenciais inválidas.";
        public static string EmailAlreadyRegistered = "O email já foi cadastrado.";
        public static string UserNameAlreadyRegistered = "O nome de usuário já foi cadastrado.";
        public static string InvalidDeactivateOperation = "Operação inválida: você não pode deletar seu próprio perfil.";
        public static string InvalidDemoteOperation = "Operação inválida: você não pode rebaixar seu próprio perfil.";
        public static string InvalidDeactivateAdminOperation = "Não é possível desativar o último administrador.";
        #endregion

        #region Jogos
        public static string GameNameRequired = "O nome do jogo é obrigatório.";
        public static string GameNameLengthInvalid = "O nome do jogo deve conter entre 3 e 20 caracteres.";
        public static string GameDescriptionLengthInvalid = "A descrição do jogo deve conter entre 5 e 100 caracteres.";
        public static string GameDescriptionRequired = "A descrição do jogo é obrigatória.";
        public static string GameGenreInvalid = "O gênero do jogo é inválido.";
        public static string GameNotFound = "O jogo não foi encontrado.";
        public static string GameIsDeactivated = "O jogo está desativado.";
        public static string GameAlreadyActive = "O jogo já está ativo.";
        public static string GameNameAlreadyExists = "Já existe um jogo com esse nome.";
        public static string GameWithoutPromotions = "Não há promoções para este jogo.";
        public static string GameWithPromotions = "Já há promoções para este jogo.";
        #endregion

        #region Pedido
        public static string OrderWithoutUser = "O pedido deve estar associado a um usuário.";
        public static string OrderWithoutGames = "O pedido deve conter pelo menos um jogo para ser finalizado.";
        public static string OrderNotDraft = "Apenas pedidos em rascunho podem ser finalizados.";
        public static string OrderGameNotDraft = "Não é possível adicionar itens a um pedido que não esteja em rascunho.";
        public static string OrderGameAlreadyAdded = "Este jogo já foi adicionado ao pedido.";
        #endregion

        #region Promoção
        public static string PeriodRequired = "O período da promoção é obrigatório.";
        public static string PromotionNotFound = "Promoção não encontrada.";
        public static string PromotionValueHigher = "O valor promocional deve ser menor que o preço base.";
        public static string PromotionAlreadyDeactivated = "A promoção já está desativada.";
        #endregion

        #region Value Objects
        public static string InvalidValue = "O valor deve ser positivo.";
        public static string PriceRequired = "O preço é obrigatório.";
        public static string EmailRequired = "O email do usuário é obrigatório.";
        public static string EmailInvalid = "O email é inválido.";
        public static string EndDateInvalid = "A data final deve ser no futuro.";
        public static string PasswordLengthInvalid = "O tamanho da senha é inválido.";
        public static string EmailLengthInvalid = "O tamanho do email é inválido.";
        public static string NameNotReal = "Por favor, informe o seu nome real.";
        public static string EmailNotReal = "Por favor, informe um email real.";
        public static string GameNameNotReal = "Por favor, informe um nome de jogo real.";
        public static string GameDescriptionNotReal = "Por favor, informe um descrição de jogo real.";
        #endregion

        #region Biblioteca
        public static string LibraryInactive = "A biblioteca está inativa.";
        public static string LibraryGameRepeated = "O usuário já possui o jogo na biblioteca.";
        #endregion
    }
}
