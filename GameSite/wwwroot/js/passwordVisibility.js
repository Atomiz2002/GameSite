function togglePassword(e) {    
    function get(e, t) {
        return e.parentElement.querySelector(t);
    }

    get(e, 'input').type = get(e, 'input').type === 'password' ? 'text' : 'password';
    get(e, 'i').classList.toggle('bi-eye');
}

