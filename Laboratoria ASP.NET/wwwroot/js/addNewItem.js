
(function () {
    const alertElement = document.querySelector("#success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        const formData = new FormData(document.querySelector('form'))
        const formValues = {}
        for (const pair of formData.entries()) {
            formValues[pair[0]] = pair[1];
        }
        const requestData = {
            method: 'POST',
            body: JSON.stringify(formValues)
        };
        const response = await fetch('/api/ExhangesAJAXV', requestData);
        const responseJson = await response.json();
        if (responseJson.success) {
            alertElement.style.display = 'block';
        }
    };

    window.addEventListener("DOMContentLoaded", () => {
        formElement.addEventListener("submit",
            event => {
                event.preventDefault();
                addNewItem().then(() => console.log("Dodano pomyślnie"));
            });
    });
})();