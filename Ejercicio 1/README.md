# OfiCentral S.A. – Pedido de Materiales de Oficina

Diseño de formularios WinForms (.NET 8) para el enunciado 1 del TP "Diseño de formularios".

## Proceso
Empleado solicita → Jefe de área aprueba → Compras genera la orden → Depósito entrega → Empleado confirma la recepción.

## Formularios

| Actor | Formulario | Tarea |
|---|---|---|
| Todos | `FrmMenuPrincipal` | Acceso a cada pantalla según el rol |
| Empleado | `FrmSolicitudMateriales` | Cargar la solicitud de insumos |
| Jefe de área | `FrmAprobacionSolicitudes` | Aprobar o rechazar solicitudes |
| Encargado de compras | `FrmOrdenCompra` | Generar la orden de compra |
| Depósito | `FrmEntregaMateriales` | Registrar la entrega de materiales |
| Empleado | `FrmConfirmacionRecepcion` | Confirmar la recepción de los insumos |

## Estructura
```
OfiCentral.PedidoMateriales/
├── OfiCentral.PedidoMateriales.sln
├── README.md
├── .gitignore
├── docs/capturas/
└── src/OfiCentral.PedidoMateriales/
    ├── OfiCentral.PedidoMateriales.csproj
    ├── Program.cs
    └── Formularios/
        ├── FrmMenuPrincipal
        ├── Empleado/   (FrmSolicitudMateriales, FrmConfirmacionRecepcion)
        ├── JefeArea/   (FrmAprobacionSolicitudes)
        ├── Compras/    (FrmOrdenCompra)
        └── Deposito/   (FrmEntregaMateriales)
```

## Cómo abrirlo
Abrir `OfiCentral.PedidoMateriales.sln` con Visual Studio 2022 (carga de trabajo "Desarrollo de escritorio de .NET") y ejecutar con F5.
