// https://docs.cypress.io/api/table-of-contents

// describe('My First Test', () => {
//   it('Visits the app root url', () => {
//     cy.visit('/')
//     cy.contains('h1', 'Welcome to Your Vue.js + TypeScript App')
//   })
// })


describe('Counter Feature' , () => { 
   it('user can access to page', () => {
    cy.visit('/')
    cy.contains('h1', 'Counter App')
   })
   it('user can increment counter', () => { 
    cy.visit('/');
    cy.get('#countInfo').contains('0');
    cy.contains('button','Incrmentar').click();
    cy.get('#countInfo').contains('1')
   })


});
//cy.visit // visitar una url
// cy.url() obtener la url la cual nos encontramos 
// cy.contains("label", "Content") comprueba si la pagina contien el elemento descripto
// cy.should('contains','hello cypress') ofrece mas opciones que el contains
//cy.request('POST','uri',{}) realizar peticiones
//cy.get('.clase');  a su clase 
//cy.get('#id'); a su id
//cy.get('[data-test-id=myId]') //obtener un elemento en funcion a su argumento
// cy.click() // Accion: click
// cy.type //accion : Escribir  