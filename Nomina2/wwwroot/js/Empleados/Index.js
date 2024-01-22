////$(function () {
////    $(".cargar").click(function () {
////        $.get('https://test-163a4.firebaseapp.com/lista.json?callback=?', function (data) {
////            $("#cuerpo").html("");
////            for (var i = 0; i < data.datos.length; i++) {
////                var tr = `<tr>
////          <td>`+ data.datos[i].nombre + `</td>
////          <td>`+ data.datos[i].apellido + `</td>
////          <td>`+ data.datos[i].cargo + `</td>
////          <td>`+ data.datos[i].empresa + `</td>
////        </tr>`;
////                $("#cuerpo").append(tr)
////            }
////        })
////    })
////})


//TABLE CONSUMO API

$(document).ready(function () {
    $('#tblEmpleados').DataTable({
        dom: 'Blfrtip',
        buttons: ['csv', 'excel', 'pdf'],
        destroy: true,
        responsive: true,
        lengthMenu: [10, 15, 20],
        language: {
            "decimal": "",
            "emptyTable": "No hay información",
            "info": "Mostrando _START_ a _END_ de _TOTAL_ Entradas",
            "infoEmpty": "Mostrando 0 to 0 of 0 Entradas",
            "infoFiltered": "(Filtrado de _MAX_ total entradas)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ Entradas",
            "loadingRecords": "Cargando...",
            "processing": "Procesando...",
            "search": "Buscar en resultado:",
            "zeroRecords": "Sin resultados encontrados",
            "paginate": {
                "first": "Primero",
                "last": "Ultimo",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        }
    });
    $('#frmEmployerNew').on('submit', function (e) {
        e.preventDefault();
        //if (!isAuthenticate()) {
        //    showExpiredSession();
        //    return;
        //} else
        //    if (!$(this).valid()) {
        //    return;
        //}
      /*  else {*/
           
            var objeto = {
                //Code: $('#txtDescripcionNew').val(),
                Name: $('#txtNombre').val(),
            };         
            $.ajax({
                beforeSend: function () {
                    $.blockUI({
                        theme: true,
                        title: 'Creando Nuevo Empleado...',
                        message: '<div class="row"><div class="col-lg-10"><br /><p><img src="/SASE/Content/assets/img/loading.gif" style="width: 35px;" /></p><p> Espere un momento por favor...</p><br /></div></div>',
                        baseZ: 10000
                    });
                },
                url: '/Empleados/AgregarEmpleado',
                type: 'POST',
                data: objeto,
                success: function (data) {  
                    $.unblockUI();
                    if (data.Code === "200") {
                        swal({
                            title: 'Correcto',
                            text: "Se creo correctamente el empleado.",
                            icon: "success",
                        });
                    } else {
                        swal({
                            title: '¡Error!',
                            text: "Ocurrio un error",
                            icon: "error",
                        });
                        return
                    }
                    document.location.href = 'https://localhost:44330/Empleados'
                },
                error: function (jqXHR, status, error) {
                    $.unblockUI();
                    swal({
                        title: "¡Error!",
                        text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                        icon: "warning",
                    });
                }
            });
        //}
    });
    SelectCompania(true)
    selectLocalidad(true)
    SelectCategoria(true);
    SelectPrestaciones(true);
    SelectCveContables(true);
    SelectCatHorarios(true);
    SelectBancos(true);
    SelectCodReservado1(true);
    SelectCodReservado2(true);
    SelectGetCodReservado3(true);
    SelectCodReservado4(true);
    SelectGetCodReservado5(true);
    SelectGetCodReservado6(true);
    SelectGetCodReservado7(true);
    SelectGetCodReservado8(true);
    SelectTipoContratos(true);
    SelectCompanias(true);
    SelectLocalidades(true)
    SelectDirecciones(true);
    SelectSubdirecciones(true);
    SelectDepartamentos(true);
    SelectPuestos(true);
    SelectCatetgoriaSueldos(true);
    SelectTurnos(true);
    SelectCveRegistroPatronal(true);
    SelectCentroBeneficios(true);
    SelectTipoNomina(true);
});

function obtenerCatalogoEmpleados() {
    let table = $('#tblEmpleados').DataTable({
        'ajax': {
            'url': '/Empleados/GetEmpleados',
            'type': 'POST',
            'datatype': 'json'
        },
        "dom": 'Bfrtip',
        "buttons": ['csv', 'excel', 'pdf'],
        "destroy": true,
        'columns': [
            { 'data': 'Code', 'autoWith': true, },
            { 'data': 'Name', 'autoWith': true },
            { 'defaultContent': '<button  onclick="EliminarEmpleadoByCode(this)"  title="Eliminar" class="btn btn-danger"><i class="fa fa-trash white" aria-hidden="true" ></i></button>' },
            { 'defaultContent': '<button  onclick="OpenModalEmpleadoEdit(this)"  title="Editar" class="btn btn-primary"><i class="fa fa-pencil white" aria-hidden="true" ></i></button>' },
            { 'defaultContent': '<button  onclick="EliminarClasificacionById(this)"  title="Detalle" class="btn btn-warning"><i class="fa fa-info-circle white" aria-hidden="true" ></i></button>' },
        ]
    });

}
function EliminarEmpleadoByCode(button) {
    if (button != undefined) {
        swal({
            title: '¡Aviso!',
            text: '¿Deseas elimar el empleado?',
            icon: 'warning',
            buttons: {
                cancel: {
                    text: "Cancelar",
                    value: false,
                    visible: true,
                    className: "",
                    closeModal: true,
                },
                confirm: {
                    text: "Eliminar",
                    value: true,
                    visible: true,
                    className: "",
                    closeModal: true
                }
            }
        }).then((result) => {
            if (result) {
                var object = {
                    CodeEmpleado: parseInt($(button).closest('tr').find('td:eq(0)').text()),
                };
                $.ajax({
                    beforeSend: function () {
                        $.blockUI({
                            theme: true, message: '<div class="row"><div class="col-lg-12"><br /><p style="font-size:small; text-align: center;"><img src="/SASE/Content/assets/img/loading.gif" style="width: 35px;" /></p><p style="font-size:small; text-align: center;"> Espere un momento por favor...</p><br /></div></div>',
                            baseZ: 10000
                        });
                    },
                    url: '/Empleados/DeleteEmployeByCode',
                    type: 'POST',
                    data: object,
                    success: function (data) {
                        $.unblockUI();
                        if (data.Code=== "200") {
                            swal("El empleado fue eliminado y tiene el estatus de BAJA", {
                                icon: "success",
                            })
                        }
                        obtenerCatalogoEmpleados();
                    },
                    error: function (jqXHR, status, error) {
                        $.unblockUI();
                        swal({
                            icon: 'warning',
                            title: 'Aviso...',
                            text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                            allowEscapeKey: true,
                            allowEnterKey: true,
                            focusCancel: true,
                            focusConfirm: true,
                        });
                    }
                });
            }
            else {
                return;
            }
        });
    }
}
function CargarDataEmpleados(button) {
    /* if (button != undefined) {*/
    let dataSet = [
        ['Tiger Nixon', 'System Architect'],
        ['Tiger Nixon', 'System Architect']]
    $('#example').DataTable({
        data: dataSet,
        dom: 'Blfrtip',
        buttons: ['csv', 'excel', 'pdf'],
        destroy: true,
        responsive: true,
        lengthMenu: [10, 15, 20],
        language: {
            "decimal": "",
            "emptyTable": "No hay información",
            "info": "Mostrando _START_ a _END_ de _TOTAL_ Entradas",
            "infoEmpty": "Mostrando 0 to 0 of 0 Entradas",
            "infoFiltered": "(Filtrado de _MAX_ total entradas)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ Entradas",
            "loadingRecords": "Cargando...",
            "processing": "Procesando...",
            "search": "Buscar en resultado:",
            "zeroRecords": "Sin resultados encontrados",
            "paginate": {
                "first": "Primero",
                "last": "Ultimo",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        columns: [
            { title: 'Code' },
            { title: 'Name' },
            { 'defaultContent': '<button  onclick="EliminarClasificacionById(this)"  title="Eliminar" class="btn btn-primary"><i class="fa fa-pencil white" aria-hidden="true" ></i></button>' },
            { 'defaultContent': '<button  onclick="EliminarClasificacionById(this)"  title="Eliminar" class="btn btn-danger"><i class="fa fa-trash white" aria-hidden="true" ></i></button>' },

        ]



    });
    //}
}
function OpenModalNuevoEmpleado(button) {
    if (button != undefined) {
        $('#mdlNuevoEmpleado').modal({ backdrop: 'static', keyboard: false })
    }

}
function OpenModalEmpleadoEdit(button) {
    if (button != undefined) {

        let _Code = $(button).closest('tr').find('td:eq(0)').text();
        let _Name = $(button).closest('tr').find('td:eq(1)').text();
        $('#txtCodeEmpleadoEdit').val(_Code);
        $('#txtNameEmpleadoEdit').val(_Name);
        $('#mdlEditEmpleado').modal({ backdrop: 'static', keyboard: false })
    }

}
function SelectCategoria(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCategoria').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }

                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCategoria').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectPrestaciones(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectPrestaciones').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }

                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectPrestaciones').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCveContables(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCveContables').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }

                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCveContables').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCatHorarios(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectHoraios').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectHoraios').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectBancos(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectBancos').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }

                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectBancos').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCodReservado1(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado1').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado1').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCodReservado2(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado2').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado2').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectGetCodReservado3(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado3').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado3').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCodReservado4(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado4').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado4').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectGetCodReservado5(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado5').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado5').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                //swal({
                //    title: "¡Error!",
                //    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                //    icon: "warning",
                //});
                reject(error);
            }
        });
    });
}
function SelectGetCodReservado6(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado6').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado6').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectGetCodReservado7(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado7').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado7').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectGetCodReservado8(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado8').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCodReservado8').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectTipoContratos(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#SelectTipoContrato').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#SelectTipoContrato').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCompanias(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCompaniaFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCompaniaFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectLocalidades(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectLocalaidadesFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectLocalaidadesFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectDirecciones(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectDireccionesFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectDireccionesFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectSubdirecciones(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectSubdireccionesFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectSubdireccionesFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectDepartamentos(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectDepartamentosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectDepartamentosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectPuestos(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectPuestosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectPuestosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCatetgoriaSueldos(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCategoriaSueldosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCategoriaSueldosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectTurnos(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectTurnosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectTurnosFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCveRegistroPatronal(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCvePatronalFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCvePatronalFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCentroBeneficios(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCentroBenficioFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCentroBenficioFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectTipoNomina(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectTipoNominaFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectTipoNominaFS').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function validaTienePlaza() {
    let existe = false;
    if (document.getElementById('selectPlazas').value > 0) {
        if (document.getElementById('selectPlazas').value === "2") {
            swal({
                title: 'warning',
                text: "No se encontro la plaza seleccionada",
                icon: "warning",
            });
            return;
        } else {
            document.location.href = 'https://localhost:44330/Empleados/Empleados'
            existe = true;
           
        }
    }
}
function cancelarCrear() {
    $('#frmEmpleadoNuevo').find('input').val('');
    //ValidatorFrmEditClasificacion.resetForm();
}
function FiltrarDatos() {

    if (document.getElementById('selectCompaniaFiltro').value > 0) {
        var _Req = {
            Compania: $('#selectCompaniaFiltro').val(),
        };
    } else {
        var _Req = {
            Compania: $('#selectLocalidadFiltro').val(),
        };
    }
    $.ajax({
        beforeSend: function () {
            $.blockUI({
                theme: true,
                message: '<div class="row"><div class="col-lg-12"><br /><p style="font-size:small; text-align: center;"><img src="./img/_loading.gif" style="width: 35px;" /></p><p style="font-size:30px; text-align: center;"> Espere un momento por favor...</p><br /></div></div>',
                baseZ: 10000
            });
        },
        url: '/Empleados/FiltroBusquedaEmpleados',
        type: 'POST',
        data: _Req,
        success: function (data) {
            var IsOK_ = data.IsOK;
            if (IsOK_ == true) {

            }
            obtenerCatalogoEmpleados();
            $.unblockUI();


        },
        error: function (jqXHR, status, error) {
            $.unblockUI();
            swal({
                icon: 'warning',
                title: 'Aviso...',
                text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                allowEscapeKey: true,
                allowEnterKey: true,
                focusCancel: true,
                focusConfirm: true,
            });
        }
    });




}
function selectLocalidad(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectLocalidadFiltro').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.dat.length; i++) {
                        $('#selectLocalidadFiltro').append('<option value =' + data.data[i].Valor + '>' + data.List[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}
function SelectCompania(isNew) {
    let _isNew = isNew;
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Empleados/GetDataSelect',
            type: 'POST',
            dataType: 'json',
            data: '{}',
            success: function (data) {
                if (_isNew) {
                    for (var i = 0; i < data.data.length; i++) {
                        $('#selectCompaniaFiltro').append('<option value =' + data.data[i].Valor + '>' + data.data[i].Descripcion + '</option>');
                    }
                } else {
                    for (var i = 0; i < data.dat.length; i++) {
                        $('#selectCompaniaFiltro').append('<option value =' + data.data[i].Valor + '>' + data.List[i].Descripcion + '</option>');
                    }
                }
                resolve(true);
            },
            error: function (jqXHR, status, error) {
                swal({
                    title: "¡Error!",
                    text: 'Surgio un error inesperado. \n' + jqXHR.status + ' ' + jqXHR.statusText,
                    icon: "warning",
                });
                reject(error);
            }
        });
    });
}