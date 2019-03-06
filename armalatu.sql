create database ArmalaTu

create table pizza(
	id int primary key,
	id_pedido int not null foreign key references pedido("id_pedido"),
	tipo_pago varchar(50) not null, --Junaeb o Normal
	masa varchar(50) not null, 		--Normal o Piedra
	tamaño varchar(50) not null,	--Individual, Mediana o Familiar
	dos_por_uno char not null,		-- S o N -> ojo que el 2x1 solo repite la misma pizza con mismos ingredientes
	nombre_pizza varchar(100) not null,
	precio int not null
)

create table pedido(
	id_pedido int primary key,
	nombre_cliente varchar(100) not null,
	direccion varchar(200) not null,
	bebida char not null, --S o N Solo de 1.5 litros -> si agrega cobrar 1500 más
	servir char not null, --S o N
	descuento int, --0 por defecto , si hay descuento poner porcentaje.
	total int not null
)

insert into pizza values('1','Normal','Normal','Mediana','N','Napolitana','5000');
insert into pizza values('2','Junaeb','Normal','Mediana','N','Napolitana','4500');


insert into pedido values('1','Juanin Juan Jarris','Siempre Viva 123','N','S','1','0','5000');
insert into pedido values('2','Johnn','Anywhere 123','N','N','2','0','4500');



select * from pedido
select * from pizza