const baseUrl = 'https://localhost:7107';

export const ENVIRONMENT = {
    api: {
        locationsBaseUrl: (baseUrl: string) => `${baseUrl}/api/Location`,
        groupsBaseUrl: (baseUrl: string) => `${baseUrl}/api/Group`,
        roomsBaseUrl: (baseUrl: string) => `${baseUrl}/api/Sala`,
        tablesBaseUrl: (baseUrl: string) => `${baseUrl}/api/Mese`,
        billItemsBaseUrl: (baseUrl: string) => `${baseUrl}/api/BillItems`,
        productsBaseUrl: (baseUrl: string) => `${baseUrl}/api/Product`,
        loginBaseUrl: (baseUrl: string) => `${baseUrl}/Login`,
    }
};
