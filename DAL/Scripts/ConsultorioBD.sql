create database ConsultorioOdontologicoDB
GO
use ConsultorioOdontologicoDB
GO

Create Table Usuarios
(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(30),
	Tipo varchar(30),
	NombreUsuario varchar(30),
	Contraseña varchar(30)
)
/*
insert into Usuarios(Nombre, Tipo, NombreUsuario, Contraseña) values
('Administrador', 'Administrador', 'Admin', '123');*/


Create Table Pacientes
(
	PacienteId int primary key identity(1,1),
	Nombres varchar(30),
	Apellidos varchar(40),
	Direccion varchar(max),
	Telefono varchar(15),
	Celular varchar(15),
	Email varchar(max),
	Genero bit,
	FechaNacimiento date,
	FechaRegistro date default getdate(),
	SeguroMedico varchar(30),
	Alergias varchar(50),
	Balance decimal,
	UsuarioId int

	Constraint Fk_Usuario Foreign key(UsuarioId) references Usuarios(UsuarioId)
) 


Create Table TiposProcedimientos
(
	TipoProcedimientoId int primary key identity(1,1),
	NombreProcedimiento varchar(30),
	Descripcion varchar(50),
	Precio decimal,
	UsuarioId int

	Constraint Fk_Usuario Foreign key(UsuarioId) references Usuarios(UsuarioId)
)

Create Table Citas
(
	CitaId int primary key identity(1,1),
	Fecha Date,
	Hora varchar(30),
	PacienteId int,
	Estado varchar(30), --si es Programado...
	Observacion varchar(30),
	UsuarioId int

	Constraint Fk_Usuario Foreign key(UsuarioId) references Usuarios(UsuarioId)
	
	Constraint Fk_CitaPaciente Foreign key (PacienteId) references Pacientes(PacienteId)
)

Create Table Procedimientos --Antiguo  HistorialCita
(
	ProcedimientoId int primary key identity(1,1),

	PacienteId int,
	TipoProcedimientoId int,
	Estado varchar(50),
	Monto decimal,
	Cobrado bit, --Si esta cobrado o no
	UsuarioId int

	Constraint Fk_Usuario Foreign key(UsuarioId) references Usuarios(UsuarioId)
	Constraint Fk_ProcedimientosPaciente Foreign key (PacienteId) references Pacientes(PacienteId),
	Constraint Fk_TipoProcedimiento Foreign key (TipoProcedimientoId) references TiposProcedimientos(TipoProcedimientoId)
)

Create Table ProcedimientosDetalles
(
	ProcedimientosDetalleId int primary key identity(1,1),
	ProcedimientoId int,
	CitaId int,
	Descripcion varchar(30),

	Constraint Fk_DetalleProcedimientos Foreign key (ProcedimientoId) references Procedimientos(ProcedimientoId),
	Constraint Fk_CitaProcedimientos Foreign key (CitaId) references Citas(CitaId),
)

Create Table Cobros
(
	CobroId int primary key identity(1,1),
	ProcedimientoId int,
	Fecha datetime,
	Abono decimal,
	UsuarioId int

	Constraint Fk_CobroProcedimiento Foreign key (ProcedimientoId) references Procedimientos(ProcedimientoId),
	Constraint Fk_UsuarioCobro Foreign key(UsuarioId) references Usuarios(UsuarioId)
)