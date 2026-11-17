// 1. Runs immediately: apply the saved theme (or the system preference) before the page is drawn
(function () {
    var theme = null;

    try {
        theme = localStorage.getItem('theme');
    } catch (e) { }

    if (!theme) {
        theme = window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light';
    }

    document.documentElement.setAttribute('data-bs-theme', theme);
})();

// 2. Functions that the Blazor toggle button calls
window.themeInterop = {
    get: function () {
        return document.documentElement.getAttribute('data-bs-theme') || 'light';
    },
    set: function (theme) {
        document.documentElement.setAttribute('data-bs-theme', theme);
        try {
            localStorage.setItem('theme', theme);
        } catch (e) { }
    }
};