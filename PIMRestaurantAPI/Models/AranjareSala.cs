using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class AranjareSala
{
    public long Id { get; set; }

    public long? Idsala { get; set; }

    public long? Idaranjare { get; set; }

    public virtual ListaSali? IdsalaNavigation { get; set; }
}
