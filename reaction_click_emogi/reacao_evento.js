
// comando responsavel por registrar as emoçoes
document.addEventListener('DOMContentLoaded', function () {
    const checkboxes = document.querySelectorAll('.btn-check');
    let selectedNumbers = []; // Array para armazenar os números dos botões selecionados

    checkboxes.forEach(function (checkbox) {
        checkbox.addEventListener('change', function () {
            const number = this.id.replace('btncheck', '');

            if (this.checked) {
                // Adiciona o número ao array de números selecionados
                selectedNumbers.push(number);
            } else {
                // Remove o número do array de números selecionados
                const index = selectedNumbers.indexOf(number);
                if (index !== -1) {
                    selectedNumbers.splice(index, 1);
                }
            }

            // Verifica se pelo menos um botão está selecionado
            const atLeastOneChecked = selectedNumbers.length > 0;

            // Mostra os números selecionados no console
            if (atLeastOneChecked) {
                console.clear();
                selectedNumbers.forEach(function (num) {
                    console.log(num);
                });
            } else {
                // Se nenhum botão estiver selecionado, exibe uma mensagem de erro no console
                console.clear();
                alert('Pelo menos uma emoção deve estar selecionada!');
            }
        });
    });
});