#include <iostream>
#include <string.h>

using namespace std;

class Lucro{

      char produto[50];
      float compra, venda;
      public:

             // variavel do void é LOCAL
             void set_produto   (char *texto);
             void set_compra    (float valor);
             void set_venda     (float valor);

             // get nao tem parametro
             char *get_produto();
             float get_compra();
             float get_venda();


              float lucroproduto();
              void verificaMargem();
              void exibir();
              void cadastrar();

			  void mostra();

};

             // PARTE DO SET

             void Lucro::set_produto(char *texto){
                   strcpy(produto, texto);
             };

               void Lucro::set_compra(float valor){
                  compra = valor;
             };


             void Lucro::set_venda(float valor){
                  venda = valor;
             };



             // PARTE DO GET
             char* Lucro::get_produto()
             {
                  return produto;
             };

            float Lucro:: get_compra(){

                 return compra;
             };
             float Lucro:: get_venda(){

                 return venda;
             };





              void Lucro::cadastrar()
             {
                 char texto[50];
                 float valor;

             cout<<"Nome do Produto:";
             fflush(stdin);
             gets(texto);
             this->set_produto(texto);

             cout<<"\nValor da compra:";
             cin>>valor;
             this->set_compra(valor);

             cout<<"\nValor da venda:";
             cin>>valor;
             this->set_venda(valor);

};
             // VAI CALCULAR O LUCRO
                float Lucro::lucroproduto(){



                return (this->get_venda() / this->get_compra() - 1) * 100;
};
             // VAI VERIFICAR O LUCRO
                void Lucro::verificaMargem(){
                if (lucroproduto() > 20)
                cout<<"Situacao: Lucro Alto!"<<endl;
                else
                 cout<<"Situacao: Lucro Baixo!"<<endl;

};

             void Lucro::exibir(){
             cout<<"<<<<<Ficha do Produto>>>>>\n\n";
             cout<<"Nome do produto:"<<this->get_produto()<<endl;
             cout<<"Valor da Compra:"<<this->get_compra()<<endl;
             cout<<"Valor da Venda:"<<this->get_venda()<<endl;
             cout<<"Margem de Lucro:"<<this->lucroproduto()<<endl;
             this->verificaMargem();


            };
main(){
    Lucro produtosLV;
    produtosLV.cadastrar();
    produtosLV.exibir();

};










