//Classe filha Administrador
class Administrador: public Usuario{
	private:
		int Setor;
		
	public:
		void setSetor(int valor);
		
		int	getSetor();
		
		void exibirDadosAdm();
};

void Administrador::setSetor(int valor){
		Setor = valor;
};

int Administrador::getSetor(){
	return Setor;
};

void Administrador::exibirDadosAdm(){
	exibirDados();
	cout<<"Setor: "<<getSetor()<<endl;
};

